using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbocharged.Vault
{
    /// <summary>
    /// An exception encountered while interacting with a Vault server.
    /// </summary>
    public class VaultException : Exception
    {
        /// <summary>
        /// The HTTP status code returned by the Vault.
        /// </summary>
        public int HttpStatusCode { get; private set; }

        /// <summary>
        /// The human-readable messages returned by the vault.
        /// </summary>
        public List<string> Messages { get; private set; }

        /// <summary>
        /// Creates a new VaultException.
        /// </summary>
        public VaultException(int httpStatusCode, List<string> messages)
            : base(messages.Count > 0 ? messages[0] : "Vault returned HTTP " + httpStatusCode)
        {
            HttpStatusCode = httpStatusCode;
            Messages = messages;
        }
    }
}
