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
    /// Authenticates with Vault using App ID authentication.
    /// </summary>
    public class AppIdAuthentication : IAuthenticationMethod
    {
        readonly string _appId;
        readonly string _userId;
        readonly string _path;

        /// <summary>
        /// Creates a new App ID authentication, using the default "app-id" path.
        /// </summary>
        /// <param name="appId">The app-id to use.</param>
        /// <param name="userId">The user-id to use.</param>
        public AppIdAuthentication(string appId, string userId)
            : this(appId, userId, "app-id")
        {
        }

        /// <summary>
        /// Creates a new App ID authentication.
        /// </summary>
        /// <param name="appId">The app-id to use.</param>
        /// <param name="userId">The user-id to use.</param>
        /// <param name="path">The path where app-id authentication is mounted.</param>
        public AppIdAuthentication(string appId, string userId, string path)
        {
            _appId = appId;
            _userId = userId;
            _path = path;

            // If they gave us "app-id/", remove the slash
            if (_path.EndsWith("/"))
                _path = _path.Substring(0, _path.Length - 1);
        }

        async Task<string> IAuthenticationMethod.GetTokenAsync(VaultClient server)
        {
            var parameters = new
            {
                app_id = _appId,
                user_id = _userId,
            };
            var lease = await server.PostAsync<Lease>("auth/" + _path + "/login", parameters).ConfigureAwait(false);
            return lease.Auth.ClientToken;
        }
    }
}
