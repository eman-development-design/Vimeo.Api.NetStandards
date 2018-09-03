using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Model;

namespace Vimeo.Api.NetStandards.Client
{
    /// <summary>
    /// Video Client
    /// </summary>
    public class VideoClient : BaseClient
    {
        public VideoClient(string accessToken) : base(accessToken)
        {
        }

        /// <summary>
        /// Determines if a video is owned by a user
        /// </summary>
        /// <param name="videoId">Video ID</param>
        /// <param name="userId">User ID</param>
        /// <returns>boolean</returns>
        public async Task<bool> DoesUserOwnVideo(long videoId, long userId)
        {
            var apiResults = await Client.GetAsync($"{BaseUrl}/user/{userId}/videos/{videoId}");

            return apiResults.StatusCode == HttpStatusCode.NotFound;
        }

        #region Resumeable Upload
        public async Task<Video> CreateVideo(long fileSize, long? userId)
        {
            var url = userId.HasValue ?
                $"{BaseUrl}/user/{userId}/videos" :
                $"{BaseUrl}/me/videos";

            var body = new UploadVideo
            {
                Upload = new Upload
                {
                    Size = fileSize
                }
            };
            var apiResults = await Client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json"));

            return new Video(); // todo
        }


        #endregion

        #region Form-Based Upload

        #endregion

        #region Pull Upload

        #endregion
    }
}