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
    /// <summary>
    /// A client for communicating with a vault server.
    /// </summary>
    partial class VaultClient
    {
        public async Task<List<string>> GetPolicyNamesAsync()
        {
            var path = "sys/policy";
            return await EnsureAuthenticated(async () =>
            {
                var response = await GetAsync<PolicyNamesResponse>(path).ConfigureAwait(false);
                return response.policies;
            }).ConfigureAwait(false);
        }

        class PolicyNamesResponse
        {
            public List<string> policies { get; set; }
        }

        class PolicyResponse
        {
            public string rules { get; set; }
        }

        public async Task<string> GetPolicyAsync(string policyName)
        {
            var path = "sys/policy/" + policyName;
            return await EnsureAuthenticated(async () =>
            {
                var response = await GetAsync<PolicyResponse>(path).ConfigureAwait(false);
                return response.rules;
            }).ConfigureAwait(false);
        }

        public async Task SetPolicyAsync(string policyName, string document)
        {
            var path = "sys/policy/" + policyName;
            var policy = new Dictionary<string, string>() { { "rules", document } };
            await EnsureAuthenticated(async () =>
            {
                var response = await PutAsync<object>(path, policy);
                return 0;
            }).ConfigureAwait(false);
        }

        public async Task DeletePolicyAsync(string policyName)
        {
            var path = "sys/policy/" + policyName;
            await EnsureAuthenticated(async () =>
            {
                var response = await DeleteAsync<object>(path);
                return 0;
            }).ConfigureAwait(false);
        }

        class SetPolicyResponse
        {
            public string rules { get; set; }
        }
    }
}
