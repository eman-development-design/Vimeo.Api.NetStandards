using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Abstract;
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
        [PublicAPI]
        public async Task<bool> DoesUserOwnVideo(long videoId, long userId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResults = await Client.GetAsync($"{BaseUrl}/user/{userId}/videos/{videoId}");

            return apiResults.StatusCode == HttpStatusCode.NotFound;
        }

        /// <summary>
        /// Initialises the upload process for vimeo
        /// </summary>
        /// <param name="uploadVideo">Upload Parameter</param>
        /// <param name="userId">UserId if not your own account.</param>
        /// <returns>Video Entity</returns>
        [PublicAPI]
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

        /// <summary>
        /// Perform a resumable upload
        /// </summary>
        /// <param name="uploadUrl">Upload URL provided by initialiseUpload method</param>
        /// <param name="file">File being uploaded</param>
        /// <param name="fileName">Filename</param>
        /// <param name="uploadOffset">upload offset</param>
        /// <returns>Upload Offset Value</returns>
        [PublicAPI]
        public async Task<long> ResumableUpload(string uploadUrl, Stream file, string fileName, long uploadOffset = 0)
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

        /// <summary>
        /// Determines of a resumable upload completed
        /// </summary>
        /// <param name="uploadUrl">Upload URL provided by initialiseUpload method</param>
        /// <returns>bool</returns>
        [PublicAPI]
        public async Task<bool> IsUploadCompleted(string uploadUrl)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Tus-Resumable", "1.0.0");

            var method = new HttpMethod("HEAD");
            var request = new HttpRequestMessage(method, uploadUrl);

            var apiResponse = await Client.SendAsync(request);
            var uploadOffsetHeader = apiResponse.Headers.GetValues("Upload-Offset").FirstOrDefault();
            var uploadLengthHeader = apiResponse.Headers.GetValues("Upload-Length").FirstOrDefault();

            return uploadLengthHeader == uploadOffsetHeader;
        }
        #endregion

        /// <summary>
        /// Get a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <returns>Video Object</returns>
        [PublicAPI]
        public async Task<Video> GetVideo(long videoId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.GetAsync($"{BaseUrl}/videos/{videoId}");

            return JsonConvert.DeserializeObject<Video>(await apiResponse.Content.ReadAsStringAsync());
        }

        #region Tags
        /// <summary>
        /// Get a video's tags
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <returns>Paging List of Tag Object</returns>
        [PublicAPI]
        public async Task<HasPaging<Tag>> GetVideoTags(long videoId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.GetAsync($"{BaseUrl}/videos/{videoId}/tags");

            return JsonConvert.DeserializeObject<HasPaging<Tag>>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Add tag to video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="tag">Tag you wanted added</param>
        /// <returns>bool</returns>
        /// <exception cref="Exception">Error Responses from API</exception>
        [PublicAPI]
        public async Task<bool> AddTagToVideo(long videoId, string tag)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.PutAsync($"{BaseUrl}/videos/{videoId}/tags/{tag}", new StringContent(tag));

            switch (apiResponse.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    throw new Exception("Tag is invalid or string was invalid.");
                case HttpStatusCode.Forbidden:
                    throw new Exception("The number of tags on the video would exceed 20.");
                default:
                    return apiResponse.StatusCode == HttpStatusCode.NoContent;
            }
        }

        /// <summary>
        /// Remove tag from video
        /// </summary>
        /// <param name="videoId">video Id</param>
        /// <param name="tag">Tag you want removed</param>
        /// <returns>bool</returns>
        /// <exception cref="Exception">Error Responses from API</exception>
        [PublicAPI]
        public async Task<bool> RemoveTagToVideo(long videoId, string tag)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync($"{BaseUrl}/videos/{videoId}/tags/{tag}");

            switch (apiResponse.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    throw new Exception("Tag was invalid.");
                default:
                    return apiResponse.StatusCode == HttpStatusCode.NoContent;
            }
        }
        #endregion

        /// <summary>
        /// Disallow a user from viewing a private video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="userId">User Id</param>
        /// <returns>bool</returns>
        /// <exception cref="Exception">Error Responses from API</exception>
        [PublicAPI]
        public async Task<bool> BlockUserAccessToVideo(long videoId, long userId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync($"{BaseUrl}/videos/{videoId}/privacy/users/{userId}");

            switch (apiResponse.StatusCode)
            {
                case HttpStatusCode.Forbidden:
                    throw new Exception("The video is not set to a user-defined access list.");
                case HttpStatusCode.NotFound:
                    throw new Exception("The user was not found.");
                default:
                    return apiResponse.StatusCode == HttpStatusCode.NoContent;
            }
        }

        /// <summary>
        /// Disallow embedding of a video on a domain
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="domain">Domain</param>
        /// <returns>bool</returns>
        /// <exception cref="Exception">Error Responses from API</exception>
        [PublicAPI]
        public async Task<bool> BlockDomainFromEmbeddingVideo(long videoId, string domain)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync($"{BaseUrl}/videos/{videoId}/privacy/domains/{domain}");

            switch (apiResponse.StatusCode)
            {
                case HttpStatusCode.Forbidden:
                    throw new Exception("The video is not set to a user-defined access list.");
                case HttpStatusCode.NotFound:
                    throw new Exception("The domain was not found.");
                default:
                    return apiResponse.StatusCode == HttpStatusCode.NoContent;
            }
        }

        /// <summary>
        /// Deletes a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <returns>bool</returns>
        [PublicAPI]
        public async Task<bool> DeleteVideo(long videoId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync($"{BaseUrl}/videos/{videoId}");

            return apiResponse.StatusCode == HttpStatusCode.NoContent;
        }
    }
}