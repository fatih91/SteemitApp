using System;
using System.Linq;
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

        public string PendingPayoutValueDollar 
        { 
            get 
            {
                var numberString = PendingPayoutValue.Replace(" SBD", "");
                float dollar = float.Parse(numberString);
                var roundedValue = Math.Round(dollar, 2);
                return roundedValue + " $";
            }
        }

        public List<Vote> ActivesVotes { get; set; }

        public List<string> Replies { get; set; }

        public string AuthorReputation { get; set; }

        public string Promoted { get; set; }

        public long BodyLength { get; set; }

        public List<string> RebloggedBy { get; set; }

        public string MainImage 
        { 
            get 
            { 
                if (JsonMetaData != null && JsonMetaData.Image != null) 
                {
                    var firstImage = JsonMetaData.Image.FirstOrDefault();
                    if (firstImage != null) 
                    {
                        return firstImage;
                    }
                }

                return "";
            }
        }

        public JsonMetaData JsonMetaData { get; set; }

        public string CreatedAgo 
        { 
            get 
            {
                var time = DateTime.Now - Created;

                if (time.Days > 0)
                {
                    return time.Days + " days ago";
                }
                else if (time.Hours > 0)
                {
                    return time.Hours + " hours ago";
                }
                else if (time.Minutes > 0)
                {
                    return time.Minutes + " minutes ago";
                }
                else if (time.Seconds > 0) 
                {
                    return time.Seconds + " seconds ago";
                }

                return "";   
            }
        }

        public int VotesCount 
        { 
            get 
            {
                if (ActivesVotes != null) 
                {
                    return ActivesVotes.Count;
                }
                return 0;
            }
        }
    }
}
