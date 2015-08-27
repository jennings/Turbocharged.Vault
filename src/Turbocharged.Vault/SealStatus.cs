using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Turbocharged.Vault
{
    public class SealStatus
    {
        [JsonProperty("sealed")]
        public bool Sealed { get; set; }

        [JsonProperty("t")]
        public int Threshold { get; set; }

        [JsonProperty("n")]
        public int NumberOfShares { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }
    }
}
