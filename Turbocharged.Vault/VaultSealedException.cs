using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbocharged.Vault
{
    public class VaultSealedException : Exception
    {
        public VaultSealedException()
            : base("Vault is sealed")
        {
        }
    }
}
