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
            Mapper.CreateMap<Tag, TagPresentation>();
        }

        public async Task<RestResult<List<TagPresentation>>> LoadTags(TagPayload Payload) 
        {
            var response = await provider.LoadTags(Payload);

            RestResult<List<TagPresentation>> result = new RestResult<List<TagPresentation>>();
            result.StatusCode = response.StatusCode;

            result.Data = response.Data
                                  .Select(Mapper.Map<Tag, TagPresentation>)
                                  .ToList();

            return result;
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
                    throw ex;
                }
            }

            result.Data = response.Data
                                  .Select(Mapper.Map<Post, PostPresentation>)
                                  .ToList();
            return result;
        }
    }
}
