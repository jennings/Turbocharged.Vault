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
    /// Base interface for Vault authentication methods.
    /// </summary>
    public interface IAuthenticationMethod
    {
        /// <summary>
        /// Returns the token to be used for the "X-Vault-Token" HTTP header.
        /// </summary>
        /// <param name="server">The VaultClient with which to authenticate.</param>
        /// <returns>The token used for the "X-Vault-Token" header.</returns>
        Task<string> GetTokenAsync(VaultClient server);
    }
}
