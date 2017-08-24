using System;
using Newtonsoft.Json;

namespace SteemitApp.Core.Models
{
    public class Vote : BaseModel
    {
        [JsonProperty("voter")]
        public string Voter { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("rshares")]
        public string Rshares { get; set; }

        [JsonProperty("percent")]
        public long Percent { get; set; }

        [JsonProperty("reputation")]
        public string Reputation { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }
    }
}
