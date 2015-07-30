using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbocharged.Vault
{
    public class VaultException : Exception
    {
        public int HttpStatusCode { get; private set; }
        public List<string> Messages { get; private set; }

        public VaultException(int httpStatusCode, List<string> messages)
            : base(messages.Count > 0 ? messages[0] : "Vault returned HTTP " + httpStatusCode)
        {
            HttpStatusCode = httpStatusCode;
            Messages = messages;
        }
    }
}
