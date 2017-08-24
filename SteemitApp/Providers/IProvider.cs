using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SteemitApp.Core.Models;

namespace SteemitApp.Core
{
    public interface IProvider
    {
        Task<RestResult<List<Discussion>>> LoadDiscussions(DiscussionPayload Payload);
    }
}
