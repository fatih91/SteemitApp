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

            Mapper.CreateMap<Discussion, DiscussionPresentation>();

                  // .ForMember(dest => dest.CreationDate, obj => obj.MapFrom(source => source.AufnahmeDatum));
        }

        public async Task<RestResult<List<DiscussionPresentation>>> LoadDiscussions(DiscussionPayload Payload)
        {
            var response = await provider.LoadDiscussions(Payload);

            RestResult<List<DiscussionPresentation>> result = new RestResult<List<DiscussionPresentation>>();

            result.StatusCode = response.StatusCode;
            result.Data = response.Data.Select(Mapper.Map<Discussion, DiscussionPresentation>).ToList();
                
            return result;
        }
    }
}
