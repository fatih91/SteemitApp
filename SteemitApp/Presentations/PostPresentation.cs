using System;
using System.Collections.Generic;
using SteemitApp.Core.Models;

namespace SteemitApp.Core
{
    public class PostPresentation
    {
        public long Id { get; set; }

        public string Author { get; set; }

        public string Permlink { get; set; }

        public string Category { get; set; }

        public string ParentAuthor { get; set; }

        public string ParentPermlink { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime LastUpdate { get; set; }

        public DateTime Created { get; set; }

        public DateTime Active { get; set; }

        public DateTime LastPayout { get; set; }

        public int Depth { get; set; }

        public int Children { get; set; }

        public long NetRshares { get; set; }

        public long AbsRshares { get; set; }

        public long VoteRshares { get; set; }

        public long ChildrenAbsRshares { get; set; }

        public DateTime CashoutTime { get; set; }

        public DateTime MaxCashoutTime { get; set; }

        public long TotalVoteWeight { get; set; }

        public long RewardWeight { get; set; }

        public string TotalPayoutValue { get; set; }

        public string CuratorPayoutValue { get; set; }

        public long AuthorRewards { get; set; }

        public long NetVotes { get; set; }

        public long RootComment { get; set; }

        public string MaxAcceptedPayout { get; set; }

        public long PercentSteemDollars { get; set; }

        public bool AllowReplies { get; set; }

        public bool AllowVotes { get; set; }

        public bool AllowCurationRewards { get; set; }

        public List<Benefit> Beneficiaries { get; set; }

        public string Url { get; set; }

        public string RootTitle { get; set; }

        public string PendingPayoutValue { get; set; }

        public string TotalPendingPayoutValue { get; set; }

        public List<Vote> ActivesVotes { get; set; }

        public List<string> Replies { get; set; }

        public string AuthorReputation { get; set; }

        public string Promoted { get; set; }

        public long BodyLength { get; set; }

        public List<string> RebloggedBy { get; set; }
    }
}
