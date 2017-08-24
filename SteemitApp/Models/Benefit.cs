using System;
using Newtonsoft.Json;

namespace SteemitApp.Core.Models
{
    public class Benefit : BaseModel
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }
    }
}
