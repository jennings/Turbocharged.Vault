using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    /// <summary>
    /// Authenticates with Vault using using simple token authentication.
    /// </summary>
    public class TokenAuthentication : IAuthenticationMethod
    {
        readonly string _token;

        /// <summary>
        /// Creates a new token authentication.
        /// </summary>
        /// <param name="token">The token.</param>
        public TokenAuthentication(string token)
        {
            _token = token;
        }

        Task<string> IAuthenticationMethod.GetTokenAsync(VaultClient server)
        {
            return Task.FromResult(_token);
        }
    }
}
