using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteemitApp.Core
{
    public class JsonMetaData
    {
        public JsonMetaData()
        {
        }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("users")]
        public List<string> Users { get; set; }

        [JsonProperty("image")]
        public List<string> Image { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }
}
