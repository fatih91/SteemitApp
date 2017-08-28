using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SteemitApp.Core.Models;

namespace SteemitApp.Core
{
    public class DataRepository : IRepository
    {
        private readonly IProvider provider;

        public DataRepository(IProvider Provider)
        {
            provider = Provider;

            Mapper.CreateMap<Post, PostPresentation>();
        }

        public async Task<RestResult<List<PostPresentation>>> LoadDiscussions(DiscussionPayload Payload)
        {
            var response = await provider.LoadDiscussions(Payload);

            RestResult<List<PostPresentation>> result = new RestResult<List<PostPresentation>>();
            result.StatusCode = response.StatusCode;

            foreach (var discussion in response.Data)
            {
                try
                {
                    var data = Mapper.Map<PostPresentation>(discussion);
                }
                catch (Exception ex)
                {
                    // 
                }
            }

            result.Data = response.Data
                                  .Select(Mapper.Map<Post, PostPresentation>)
                                  .ToList();
            return result;
        }
    }
}
