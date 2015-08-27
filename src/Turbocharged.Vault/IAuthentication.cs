using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    public interface IAuthenticationMethod
    {
        Task<string> GetTokenAsync(VaultClient server);
    }
}
