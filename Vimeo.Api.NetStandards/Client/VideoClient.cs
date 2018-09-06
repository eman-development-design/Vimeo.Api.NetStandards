using System;
using System.IO;
using System.Linq;
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

        #region Upload
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

        public async Task<Video> InitialiseUpload(UploadVideo uploadVideo, long? userId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var url = userId.HasValue ?
                $"{BaseUrl}/user/{userId}/videos" :
                $"{BaseUrl}/me/videos";

            var apiResults = await Client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(uploadVideo), Encoding.UTF8, "application/json"));

            var videoInfo = JsonConvert.DeserializeObject<Video>(await apiResults.Content.ReadAsStringAsync());

            return videoInfo;
        }

        public async Task<long> ResumeableUpload(string uploadUrl, Stream file, string fileName, long uploadOffset = 0)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Tus-Resumable", "1.0.0");
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Upload-Offset", uploadOffset.ToString());
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/offset+octet-stream");

            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, uploadUrl)
            {
                Content = new MultipartFormDataContent
                {
                    new StreamContent(file)
                }
            };

            var apiResponse = await Client.SendAsync(request);
            var uploadOffsetHeader = apiResponse.Headers.GetValues("Upload-Offset").FirstOrDefault();

            return Convert.ToInt64(uploadOffsetHeader);
        }

        public async Task<bool> IsUploadCompleted(string uploadUrl)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Tus-Resumable", "1.0.0");

            var method = new HttpMethod("HEAD");
            var request = new HttpRequestMessage(method, uploadUrl);

            var apiResponse = await Client.SendAsync(request);
            var uploadOffsetHeader = apiResponse.Headers.GetValues("Upload-Offset").FirstOrDefault();
            var uploadLengthHeader = apiResponse.Headers.GetValues("Upload-Length").FirstOrDefault();

            return uploadLengthHeader == uploadOffsetHeader;
        }
        #endregion
    }
}