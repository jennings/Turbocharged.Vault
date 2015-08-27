using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    public class AppIdAuthentication : IAuthenticationMethod
    {
        readonly string _appId;
        readonly string _userId;

        public AppIdAuthentication(string appId, string userId)
        {
            _appId = appId;
            _userId = userId;
        }

        public async Task<string> GetTokenAsync(VaultClient server)
        {
            var parameters = new
            {
                app_id = _appId,
                user_id = _userId,
            };
            var lease = await server.PostAsync<Lease>("auth/app-id/login", parameters).ConfigureAwait(false);
            return lease.Auth.ClientToken;
        }
    }
}
