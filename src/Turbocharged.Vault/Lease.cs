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
    /// A secret leased from the vault.
    /// </summary>
    public class Lease
    {
        /// <summary>
        /// The ID of the lease, used for renewals.
        /// </summary>
        [JsonProperty("lease_id")]
        public string LeaseId { get; set; }

        /// <summary>
        /// The duration in seconds for which the lease is valid.
        /// </summary>
        [JsonProperty("lease_duration")]
        public int LeaseDuration
        {
            get { return _leaseDuration; }
            set
            {
                _leaseDuration = value;
                LeaseEnd = DateTimeOffset.Now.AddSeconds(value);
            }
        }

        int _leaseDuration;

        /// <summary>
        /// Gets the time when the lease expires.
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset LeaseEnd { get; private set; }

        /// <summary>
        /// Indicates whether this lease can be rewnewed.
        /// </summary>
        [JsonProperty("renewable")]
        public bool Renewable { get; set; }

        /// <summary>
        /// The data associated with this lease.
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, object> Data { get; set; }

        [JsonProperty("auth")]
        internal AuthObject Auth { get; set; }

        /// <summary>
        /// Creates a new Lease.
        /// </summary>
        public Lease()
        {
            Data = new Dictionary<string, object>();
        }

        internal class AuthObject
        {
            [JsonProperty("client_token")]
            public string ClientToken { get; set; }

            [JsonProperty("policies")]
            public List<string> Policies { get; set; }

            [JsonProperty("lease_duration")]
            public int LeaseDuration { get; set; }

            [JsonProperty("renewable")]
            public bool Renewable { get; set; }
        }
    }
}
