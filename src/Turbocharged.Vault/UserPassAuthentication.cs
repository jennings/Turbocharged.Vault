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
    /// Authenticates with Vault using using a username and password.
    /// This can also be used for the LDAP backend.
    /// </summary>
    public class UserPassAuthentication : IAuthenticationMethod
    {
        readonly string _username;
        readonly string _password;
        readonly string _path;

        /// <summary>
        /// Creates a new username and password authentication,
        /// using the default mount path of "userpass".
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public UserPassAuthentication(string username, string password)
            : this(username, password, "userpass")
        {
        }

        /// <summary>
        /// Creates a new username and password authentication.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="path">The path where userpass authentication is mounted.</param>
        public UserPassAuthentication(string username, string password, string path)
        {
            _username = username;
            _password = password;
            _path = path;
        }

        async Task<string> IAuthenticationMethod.GetTokenAsync(VaultClient server)
        {
            var obj = new { password = _password };
            var lease = await server.PostAsync<Lease>("auth/" + _path + "/login/" + _username, obj).ConfigureAwait(false);
            return lease.Auth.ClientToken;
        }
    }
}
