using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SteemitApp.Core.Models;

namespace SteemitApp.Core
{
    public interface IProvider
    {
        Task<RestResult<List<Post>>> LoadDiscussions(DiscussionPayload Payload);
        Task<RestResult<List<Tag>>> LoadTags(TagPayload Payload);
    }
}
