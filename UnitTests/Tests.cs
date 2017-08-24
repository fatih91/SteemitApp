using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using SteemitApp.Core;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UnitTests
{
    [TestFixture()]
    public class Tests
    {
        IProvider provider;

        public Tests()
        {
            
        }

        [SetUp]
        public void BeforeEachTest()
        {
            provider = new RestProvider();
        }

        [Test]
        public void AppLaunches()
        {
            // app.Screenshot("First screen.");
        }

        [Test]
        public async Task LoadDiscussions_Succeed()
        {
            var payload = new DiscussionPayload();
            payload.Tag = "steem";

            var result = await provider.LoadDiscussions(payload);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.StatusCode == System.Net.HttpStatusCode.OK);
            Assert.IsTrue(result.Data.Count > 0);
        }
    }
}
