using System;
namespace SteemitApp.Core
{
    public class TagPresentation
    {
        public TagPresentation()
        {
        }

        public string Name { get; set; }

        public string TotalPayouts { get; set; }

        public long NetVotes { get; set; }

        public long TopPosts { get; set; }

        public long Comments { get; set; }

        public string Trending { get; set; }
    }
}
