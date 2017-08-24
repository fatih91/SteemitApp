using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SteemitApp.Core.Models
{
    public class Discussion : BaseModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("permlink")]
        public string Permlink { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("parent_author")]
        public string ParentAuthor { get; set; }

        [JsonProperty("parent_permlink")]
        public string ParentPermlink { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        // "json_metadata": "{"tags":["steemit","steem","condenser","mobile"],"users":["steemitdev","steemitblog"],"image":["https://cdn.pixabay.com/photo/2016/09/15/18/28/update-1672349_1280.png"],"app":"steemit/0.1","format":"markdown"}",
        // [JsonProperty("json_metadata")]
        // public MetaData MetaData { get; set; }

        // "last_update": "2017-08-23T19:13:42",
        [JsonProperty("last_update")]
        public DateTime LastUpdate { get; set; }

        // "created": "2017-08-23T19:13:42",
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        // "active": "2017-08-24T15:19:39",
        [JsonProperty("active")]
        public DateTime Active { get; set; }

        // "last_payout": "1970-01-01T00:00:00",
        [JsonProperty("last_payout")]
        public DateTime LastPayout { get; set; }

        // "depth": 0,
        [JsonProperty("depth")]
        public int Depth { get; set; }

        // "children": 197,
        [JsonProperty("children")]
        public int Children { get; set; }

        [JsonProperty("net_rshares")]
        public long NetRshares { get; set; }

        // "abs_rshares": "205683424812436",
        [JsonProperty("abs_rshares")]
        public long AbsRshares { get; set; }

        // "vote_rshares": "205682902529133",
        [JsonProperty("vote_rshares")]
        public long VoteRshares { get; set; }

        // "children_abs_rshares": "235582600666094",
        [JsonProperty("children_abs_rshares")]
        public long ChildrenAbsRshares { get; set; }

        // "cashout_time": "2017-08-30T19:13:42",
        [JsonProperty("cashout_time")]
        public DateTime CashoutTime { get; set; }

        // "max_cashout_time": "1969-12-31T23:59:59",
        [JsonProperty("max_cashout_time")]
        public DateTime MaxCashoutTime { get; set; }

        // "total_vote_weight": 14518323,
        [JsonProperty("total_vote_weight")]
        public long TotalVoteWeight { get; set; }

        [JsonProperty("reward_weight")]
        // "reward_weight": 10000,
        public long RewardWeight { get; set; }

        [JsonProperty("total_payout_value")]
        // "total_payout_value": "0.000 SBD",
        public string TotalPayoutValue { get; set; }

        [JsonProperty("curator_payout_value")]
        // "curator_payout_value": "0.000 SBD",
        public string CuratorPayoutValue { get; set; }

        [JsonProperty("author_rewards")]
        // "author_rewards": 0,
        public long AuthorRewards { get; set; }

        [JsonProperty("net_votes")]
        // "net_votes": 395,
        public long NetVotes { get; set; }

        [JsonProperty("root_comment")]
        // "root_comment": 10887082,
        public long RootComment { get; set; }

        [JsonProperty("max_accepted_payout")]
        // "max_accepted_payout": "0.000 SBD",
        public string MaxAcceptedPayout { get; set; }

        [JsonProperty("percent_steem_dollars")]
        // "percent_steem_dollars": 10000,
        public long PercentSteemDollars { get; set; }

        [JsonProperty("allow_replies")]
        public bool AllowReplies { get; set; }

        [JsonProperty("allow_votes")]
        public bool AllowVotes { get; set; }

        [JsonProperty("allow_curation_rewards")]
        // "allow_curation_rewards": true,
        public bool AllowCurationRewards { get; set; }

        [JsonProperty("beneficiaries")]
        // "beneficiaries": [],
        public List<Benefit> Beneficiaries { get; set; }

        [JsonProperty("url")]
        // "url": "/steemit/@steemitblog/the-state-of-steem-august-expansion",
        public string Url { get; set; }

        [JsonProperty("root_title")]
        // "root_title": "The State of Steem - August Expansion",
        public string RootTitle { get; set; }

        [JsonProperty("pending_payout_value")]
        // "pending_payout_value": "718.678 SBD",
        public string PendingPayoutValue { get; set; }

        [JsonProperty("total_pending_payout_value")]
        // "total_pending_payout_value": "0.000 STEEM",
        public string TotalPendingPayoutValue { get; set; }

        [JsonProperty("active_votes")]
        // "active_votes": [],
        public List<Vote> ActivesVotes { get; set; }

        [JsonProperty("replies")]
        // "replies": [],
        public List<string> Replies { get; set; }

        [JsonProperty("author_reputation")]
        // "author_reputation": "89466323855266",
        public string AuthorReputation { get; set; }

        [JsonProperty("promoted")]
        // "promoted": "2.000 SBD",
        public string Promoted { get; set; }

        [JsonProperty("body_length")]
        // "body_length": 2053,
        public long BodyLength { get; set; }

        [JsonProperty("reblogged_by")]
        // "reblogged_by": [],
        public List<string> RebloggedBy { get; set; }
    }
}
