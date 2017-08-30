using System;
namespace SteemitApp.Core
{
    public class TagPayload
    {
        public TagPayload()
        {

        }

        public TagPayload(string AfterTag, string Limit)
        {
            this.AfterTag = AfterTag;
            this.Limit = Limit;
        }

        public string AfterTag { get; set; } = "steemit";
        public string Limit { get; set; } = "20";
    }
}
