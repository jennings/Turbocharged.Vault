using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Turbocharged.Vault.Tests
{
    public class VaultClientPolicyFacts
    {
        TokenAuthentication _token;
        Uri _uri;

        Dictionary<string, object> EMPTY_SECRET = new Dictionary<string, object>();

        public VaultClientPolicyFacts ()
        {
            _token = new TokenAuthentication(Configuration.Token);
            _uri = Configuration.VaultUri;
        }

        [Fact]
        public async Task CanGetAListOfPolicyNames()
        {
            var client = new VaultClient(_uri, _token);
            var names = await client.GetPolicyNamesAsync();
            Assert.True(names.Count > 0);
            Assert.True(names.Contains("root"));
        }

        [Fact]
        public async Task CanGetTheRootPolicy()
        {
            var client = new VaultClient(_uri, _token);
            var rootPolicy = await client.GetPolicyAsync("root");
            Assert.NotNull(rootPolicy); // root policy is an empty string
        }

        [Fact]
        public async Task CanSetAndGetAPolicy()
        {
            var policyName = "foo";
            var policyDocument = @"path ""secret/foo"" { policy = ""sudo"" }";
            var client = new VaultClient(_uri, _token);

            await client.DeletePolicyAsync(policyName);
            await client.SetPolicyAsync(policyName, policyDocument);

            var policy = await client.GetPolicyAsync(policyName);
            Assert.True(policy.Length > 0);
        }
    }
}
