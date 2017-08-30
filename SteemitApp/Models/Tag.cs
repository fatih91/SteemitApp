using System;
using Newtonsoft.Json;

namespace SteemitApp.Core.Models
{
    public class Tag : BaseModel
    {
        /*
{
    "name": "life",
    "total_payouts": "4740634.679 SBD",
    "net_votes": 1073342,
    "top_posts": 48564,
    "comments": 26419,
    "trending": "234118578"
  },
         */

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("total_payouts")]
        public string TotalPayouts { get; set; }

        [JsonProperty("net_votes")]
        public long NetVotes { get; set; }

        [JsonProperty("top_posts")]
        public long TopPosts { get; set; }

        [JsonProperty("comments")]
        public long Comments { get; set; }

        [JsonProperty("trending")]
        public string Trending { get; set; }
    }
}
