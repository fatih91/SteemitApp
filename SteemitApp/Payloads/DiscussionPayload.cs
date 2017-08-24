using System;
using Newtonsoft.Json;

namespace SteemitApp.Core
{
    public class DiscussionPayload
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; } = "10";

        [JsonProperty("start_author")]
        public string StartAuthor { get; set; }

        [JsonProperty("start_permlink")]
        public string StartPermlink { get; set; }
    }
}
