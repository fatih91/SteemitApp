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

            var response = await client.GetAsync($"get_discussions_by_trending?query={jsonPayload}");
            var rawJson = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<Post>>(rawJson);

            return new RestResult<List<Post>> 
            { 
                Data = list, 
                StatusCode = response.StatusCode 
            };
        }
    }
}
