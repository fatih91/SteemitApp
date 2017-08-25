using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SteemitApp.Core;
using SteemitApp.Core.Models;

namespace SteemitApp.Core
{
    public interface IRepository
    {
        Task<RestResult<List<PostPresentation>>> LoadDiscussions(DiscussionPayload Payload);
    }
}
