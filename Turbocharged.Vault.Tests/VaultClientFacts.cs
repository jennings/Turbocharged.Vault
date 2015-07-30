using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Turbocharged.Vault.Tests
{
    public class VaultClientFacts
    {
        TokenAuthentication _token;
        AppIdAuthentication _appId;
        Uri _uri;

        public VaultClientFacts()
        {
            _token = new TokenAuthentication("5670e985-0b2a-39de-5ab1-19e1f4d90093");
            _appId = new AppIdAuthentication("foo", "bar");
            _uri = new Uri("http://172.16.80.1:8200");
        }

        async Task<VaultClient> InitializeWithTokenAsync()
        {
            var vault = new VaultClient(_uri, _token);
            await vault.InitializeAsync();
            return vault;
        }

        async Task<VaultClient> InitializeWithAppId()
        {
            var vault = new VaultClient(_uri, _appId);
            await vault.InitializeAsync();
            return vault;
        }

        [Fact]
        public async Task CanRequestSealStatus()
        {
            var vault = await InitializeWithTokenAsync();
            var response = await vault.SealStatusAsync();
            Assert.NotNull(response);
            Assert.Equal(false, response.Sealed);
        }

        [Fact]
        public async Task CanWriteAndReadSecrets()
        {
            var path = "secret/foo";
            var expectedValue = Guid.NewGuid().ToString();
            var obj = new Dictionary<string, object>() { { "Value", expectedValue } };
            var vault = await InitializeWithTokenAsync();
            await vault.WriteSecretAsync(path, obj);
            var result = await vault.LeaseAsync(path);
            Assert.NotNull(result);
            Assert.Equal(expectedValue, result.Data["Value"]);
        }

        [Fact]
        public async Task CanDeleteSecrets()
        {
            var path = "secret/foo";
            var expectedValue = Guid.NewGuid().ToString();
            var obj = new Dictionary<string, object>() { { "Value", expectedValue } };
            var vault = await InitializeWithTokenAsync();
            await vault.WriteSecretAsync(path, obj);
            await vault.DeleteSecretAsync(path);
            var result = await vault.LeaseAsync(path);
            Assert.Null(result);
        }

        [Fact]
        public async Task CanUseAppIdAuthentication()
        {
            var vault = await InitializeWithAppId();
            await vault.WriteSecretAsync("foo", new Dictionary<string, object> { { "", "" } });
        }
    }
}
