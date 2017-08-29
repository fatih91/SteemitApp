using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ModernHttpClient;
using Newtonsoft.Json;
using SteemitApp.Core.Models;

namespace SteemitApp.Core
{
    public class RestProvider : IProvider
    {
        private readonly HttpClient client;

        public RestProvider()
        {
            client = new HttpClient(new NativeMessageHandler());
            client.BaseAddress = new Uri("https://api.steemjs.com");
        }

        public async Task<RestResult<List<Post>>> LoadDiscussions(DiscussionPayload Payload)
        {
            var jsonPayload = JsonConvert.SerializeObject(Payload);

            var restResource = "get_discussions_by_trending";

            switch (Payload.Type)
            {
                case DiscussionCategory.Trending:
                    restResource = "get_discussions_by_trending";
                    break;
                case DiscussionCategory.Promoted:
                    restResource = "get_discussions_by_promoted";
                    break;
                case DiscussionCategory.New:
                    restResource = "get_discussions_by_created";
                    break;
                case DiscussionCategory.Hot:
                    restResource = "get_discussions_by_hot";
                    break;
            }

            var response = await client.GetAsync($"{restResource}?query={jsonPayload}");
            var rawJson = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<Post>>(rawJson);

            if (list != null) 
            {
                foreach (var post in list)
                {
                    post.JsonMetaData = JsonConvert.DeserializeObject<JsonMetaData>(post.JsonMetaDataString);
                }
            }

            return new RestResult<List<Post>> 
            { 
                Data = list, 
                StatusCode = response.StatusCode 
            };
        }
    }
}
