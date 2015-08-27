using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    /// <summary>
    /// A backend mounted in the vault.
    /// </summary>
    public class Mount
    {
        /// <summary>
        /// The path where the backend is mounted.
        /// </summary>
        [JsonIgnore]
        public string Path { get; set; }

        /// <summary>
        /// The type of backend, e.g., "generic", "aws", etc.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A description of this backend.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1})", Type, Path);
        }
    }
}
