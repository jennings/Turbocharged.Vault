using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    public class VaultClient
    {
        readonly HttpClient _client = new HttpClient();
        readonly Uri _baseUri;
        readonly SemaphoreSlim _authLock = new SemaphoreSlim(1, 1);

        bool _authenticated = false;
        IAuthenticationMethod _auth;

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

        /// <summary>
        /// Changes the method used to authenticate with the Vault.
        /// </summary>
        public Task AuthenticateAsync(IAuthenticationMethod authentication)
        {
            _auth = authentication;
            return AuthenticateAsync(force: true);
        }

        async Task AuthenticateAsync(bool force)
        {
            if (force || !_authenticated)
            {
                await _authLock.WaitAsync().ConfigureAwait(false);
                try
                {
                    if (force || !_authenticated)
                    {
                        const string HEADER = "X-Vault-Token";
                        var token = await _auth.GetTokenAsync(this).ConfigureAwait(false);
                        _client.DefaultRequestHeaders.Remove(HEADER);
                        _client.DefaultRequestHeaders.Add(HEADER, token);
                        _authenticated = true;
                    }
                }
                finally
                {
                    _authLock.Release();
                }
            }
        }

        internal async Task<T> EnsureAuthenticated<T>(Func<Task<T>> func)
        {
            await AuthenticateAsync(force: false).ConfigureAwait(false);
            try
            {
                return await func().ConfigureAwait(false);
            }
            catch (SecurityException)
            {
                // Continue outside the catch...
            }

            // Second try
            await AuthenticateAsync(force: true).ConfigureAwait(false);
            return await func().ConfigureAwait(false);
        }

        internal async Task<T> GetAsync<T>(string path)
        {
            var uri = new Uri(_baseUri, path);
            var response = await _client.GetAsync(uri).ConfigureAwait(false);
            return await ParseResponseAsync<T>(response).ConfigureAwait(false);
        }

        internal async Task<T> PostAsync<T>(string path, object parameters)
        {
            var uri = new Uri(_baseUri, path);
            var content = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8);
            var response = await _client.PostAsync(uri, content).ConfigureAwait(false);
            return await ParseResponseAsync<T>(response);
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
                    throw new SecurityException("Unauthorized");

                default:
                    var errors = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    var messages = JsonConvert.DeserializeObject<ErrorResponse>(errors);
                    if (messages != null && messages.Errors != null)
                    {
                        throw new VaultException((int)response.StatusCode, messages.Errors);
                    }
                    else
                    {
                        throw new VaultException((int)response.StatusCode, new List<string>() { response.StatusCode.ToString() });
                    }
            }
        }

        class ErrorResponse
        {
            [JsonProperty("errors")]
            public List<string> Errors { get; set; }
        }

        /// <summary>
        /// Queries the Vault for whether it is currently sealed.
        /// </summary>
        /// <returns>The seal status of the Vault.</returns>
        public Task<SealStatus> SealStatusAsync()
        {
            return GetAsync<SealStatus>("sys/seal-status");
        }

        /// <summary>
        /// Writes a new secret to the Vault, or replaces an existing one.
        /// </summary>
        public Task WriteSecretAsync(string path, IDictionary<string, object> value)
        {
            return EnsureAuthenticated(() =>
            {
                return PostAsync<object>(path, value);
            });
        }

        /// <summary>
        /// Deletes a secret from the Vault.
        /// </summary>
        public async Task DeleteSecretAsync(string path)
        {
            var uri = new Uri(_baseUri, path);
            await EnsureAuthenticated(async () =>
            {
                var response = await _client.DeleteAsync(uri).ConfigureAwait(false);
                return await ParseResponseAsync<object>(response);
            });
        }

        /// <summary>
        /// Leases a secret from the Vault.
        /// </summary>
        /// <returns>The lease, or null if the secret doesn't exist.</returns>
        public async Task<Lease> LeaseAsync(string path)
        {
            var uri = new Uri(_baseUri, path);
            return await EnsureAuthenticated(async () =>
            {
                var response = await _client.GetAsync(uri).ConfigureAwait(false);
                return await ParseResponseAsync<Lease>(response).ConfigureAwait(false);
            });
        }

        /// <summary>
        /// Renews the lease on a secret.
        /// </summary>
        /// <returns>A renewed lease.</returns>
        public async Task<Lease> RenewAsync(Lease lease)
        {
            var uri = new Uri(_baseUri, "sys/renew/" + lease.LeaseId);
            return await EnsureAuthenticated(async () =>
            {
                var response = await _client.PutAsync(uri, null).ConfigureAwait(false);
                return await ParseResponseAsync<Lease>(response);
            });
        }
    }
}
