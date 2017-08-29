using System;
using Newtonsoft.Json;

namespace SteemitApp.Core
{
    public class DiscussionPayload
    {
        public DiscussionPayload()
        {

        }

        public DiscussionPayload(string Tag, string Limit)
        {
            this.Tag = Tag;
            this.Limit = Limit;
        }

        public DiscussionPayload(string Tag, string Limit, string StartAuthor, string StartPermlink)
        {
            this.Tag = Tag;
            this.Limit = Limit;
            this.StartAuthor = StartAuthor;
            this.StartPermlink = StartPermlink;
        }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; } = "10";

        [JsonProperty("start_author")]
        public string StartAuthor { get; set; }

        [JsonProperty("start_permlink")]
        public string StartPermlink { get; set; }

        [JsonIgnore]
        public DiscussionCategory Type { get; set; } = DiscussionCategory.Trending;
    }
}
