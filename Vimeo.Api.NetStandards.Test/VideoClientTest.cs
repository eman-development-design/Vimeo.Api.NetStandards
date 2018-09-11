using System.Threading.Tasks;
using NUnit.Framework;
using Vimeo.Api.NetStandards.Client;

namespace Vimeo.Api.NetStandards.Test
{
    [TestFixture]
    public class VideoClientTest
    {
        [SetUp]
        public void init()
        {
            var client = new VideoClient("AccessTokenHere");
        }

        [Test]
        public async Task AddCommentTest()
        {
            // todo:
        }
    }
}