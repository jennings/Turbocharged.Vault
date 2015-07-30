using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    public class TokenAuthentication : IAuthenticationMethod
    {
        readonly string _token;

        public TokenAuthentication(string token)
        {
            _token = token;
        }

        public Task<string> GetTokenAsync(VaultClient server)
        {
            return Task.FromResult(_token);
        }
    }
}
