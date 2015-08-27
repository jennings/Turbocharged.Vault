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
    /// The seal status of a vault.
    /// </summary>
    public class SealStatus
    {
        /// <summary>
        /// Indicates the vault is sealed. If true, the vault must be unsealed
        /// before any other operation will succeed.
        /// </summary>
        [JsonProperty("sealed")]
        public bool Sealed { get; set; }

        /// <summary>
        /// The number of unseal keys required to unseal the vault.
        /// </summary>
        [JsonProperty("t")]
        public int Threshold { get; set; }

        /// <summary>
        /// The total number of unseal keys that have been issued.
        /// </summary>
        [JsonProperty("n")]
        public int NumberOfShares { get; set; }

        /// <summary>
        /// The number of unseal keys that have been entered.
        /// This number increments each time an unseal key is entered.
        /// When this number reaches <c>Threshold</c>, the vault will
        /// attempt to unseal itself.
        /// </summary>
        [JsonProperty("progress")]
        public int Progress { get; set; }
    }
}
