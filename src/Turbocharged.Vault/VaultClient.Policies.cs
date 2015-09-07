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
            var response = await GetWithAuthenticationCheckAsync<PolicyResponse>(path).ConfigureAwait(false);
            return response.rules;
        }

        public async Task SetPolicyAsync(string policyName, string document)
        {
            var path = "sys/policy/" + policyName;
            var policy = new Dictionary<string, string>() { { "rules", document } };
            await PutWithAuthenticationCheckAsync<object>(path, policy);
        }

        public Task DeletePolicyAsync(string policyName)
        {
            var path = "sys/policy/" + policyName;
            return DeleteWithAuthenticationCheckAsync<object>(path);
        }

        class SetPolicyResponse
        {
            public string rules { get; set; }
        }
    }
}
