using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    public class Lease
    {
        [JsonProperty("lease_id")]
        public string LeaseId { get; set; }

        [JsonProperty("lease_duration")]
        public int LeaseDuration { get; set; }

        [JsonProperty("renewable")]
        public bool Renewable { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, object> Data { get; set; }

        [JsonProperty("auth")]
        internal AuthObject Auth { get; set; }

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
