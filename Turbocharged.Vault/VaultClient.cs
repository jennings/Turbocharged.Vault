using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    public class VaultClient
    {
        readonly HttpClient _client = new HttpClient();
        readonly Uri _baseUri;
        readonly IAuthenticationMethod _auth;

        /// <summary>
        /// A client for communicating with a Vault server.
        /// </summary>
        /// <param name="baseUri">The URI of the Vault server</param>
        /// <param name="authentication">The authentication method to use</param>
        public VaultClient(Uri baseUri, IAuthenticationMethod authentication)
        {
            _baseUri = new Uri(baseUri, "v1/");
            _auth = authentication;
        }

        public async Task InitializeAsync()
        {
            var token = await _auth.GetTokenAsync(this).ConfigureAwait(false);
            _client.DefaultRequestHeaders.Add("X-Vault-Token", token);
        }

        internal Task<HttpResponseMessage> GetAsync(string path)
        {
            var uri = new Uri(_baseUri, path);
            return _client.GetAsync(uri);
        }

        internal Task<HttpResponseMessage> PostAsync(string path, object parameters)
        {
            var uri = new Uri(_baseUri, path);
            var content = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8);
            return _client.PostAsync(uri, content);
        }

        async Task<T> ParseResponseAsync<T>(HttpResponseMessage response)
        {
            switch ((int)response.StatusCode)
            {
                case 200:
                    var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return JsonConvert.DeserializeObject<T>(content);

                case 204:
                case 404:
                    return default(T);

                case 401:
                    throw new SecurityException("Not authorized");

                case 429:
                    throw new Exception("Rate limit exceeded");

                case 503:
                    throw new VaultSealedException();

                case 500:
                default:
                    throw new Exception("HTTP " + response.StatusCode);
            }
        }

        public async Task<SealStatus> SealStatusAsync()
        {
            var response = await GetAsync("sys/seal-status").ConfigureAwait(false);
            return await ParseResponseAsync<SealStatus>(response).ConfigureAwait(false);
        }

        public async Task WriteSecretAsync(string path, IDictionary<string, object> value)
        {
            var response = await PostAsync(path, value).ConfigureAwait(false);
            await ParseResponseAsync<SealStatus>(response).ConfigureAwait(false);
        }

        public async Task DeleteSecretAsync(string path)
        {
            var uri = new Uri(_baseUri, path);
            var response = await _client.DeleteAsync(uri).ConfigureAwait(false);
            await ParseResponseAsync<object>(response);
        }

        /// <summary>
        /// Returns a lease for a secret, or null if the secret doesn't exist.
        /// </summary>
        public async Task<Lease> LeaseAsync(string path)
        {
            var uri = new Uri(_baseUri, path);
            var response = await _client.GetAsync(uri).ConfigureAwait(false);
            return await ParseResponseAsync<Lease>(response).ConfigureAwait(false);
        }

        public async Task<Lease> RenewAsync(Lease lease)
        {
            var uri = new Uri(_baseUri, "sys/renew/" + lease.LeaseId);
            var response = await _client.PutAsync(uri, null).ConfigureAwait(false);
            return await ParseResponseAsync<Lease>(response);
        }

        void HandleError(HttpResponseMessage response)
        {
            if (response.StatusCode == (HttpStatusCode)401)
            {
                throw new System.Security.SecurityException();
            }
            else if (response.StatusCode == (HttpStatusCode)503)
            {
                throw new VaultSealedException();
            }
        }
    }
}
