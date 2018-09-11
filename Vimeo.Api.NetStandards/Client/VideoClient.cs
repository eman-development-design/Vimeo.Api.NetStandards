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
using Vimeo.Api.NetStandards.Types;

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

            var apiResults = await Client.GetAsync(BuildUrl($"user/{userId}/videos/{videoId}"));

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
                BuildUrl($"user/{userId}/videos") :
                BuildUrl("me/videos");

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
        /// <param name="fields">Fields we want to return back (Optional)</param>
        /// <returns>Video Object</returns>
        [PublicAPI]
        public async Task<Video> GetVideo(long videoId, string[] fields = null)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.GetAsync(BuildGetUrl($"videos/{videoId}", fields));

            return JsonConvert.DeserializeObject<Video>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Get a video's related videos
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="fields">Fields we want to return back (Optional)</param>
        /// <param name="page">Current Page (Optional)</param>
        /// <param name="perPage">Items per page (Optional)</param>
        /// <param name="contentRatingFilter">Filter by Video's Content Rating (Optional)</param>
        /// <returns>Paging list of Video</returns>
        [PublicAPI]
        public async Task<HasPaging<Video>> GetRelatedVideos(long videoId, string[] fields = null, int? page = null, int? perPage = null, string[] contentRatingFilter = null)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.GetAsync(BuildGetUrl($"videos/{videoId}/videos", fields, page, perPage, null, null, "related", contentRatingFilter));

            return JsonConvert.DeserializeObject<HasPaging<Video>>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Get all Creative Commons licenses
        /// </summary>
        /// <param name="fields">Fields we want to return back (Optional)</param>
        /// <param name="page">Current Page (Optional)</param>
        /// <param name="perPage">Items per page (Optional)</param>
        /// <returns>Paging list of select list object</returns>
        [PublicAPI]
        public async Task<HasPaging<SelectList>> GetCreativeCommonsLicenses(string[] fields = null, int? page = null, int? perPage = null)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.GetAsync(BuildGetUrl($"creativecommons", fields, page, perPage));

            return JsonConvert.DeserializeObject<HasPaging<SelectList>>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Get all comments on a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="fields">Fields we want to return back (Optional)</param>
        /// <param name="page">Current Page (Optional)</param>
        /// <param name="perPage">Items per page (Optional)</param>
        /// <returns>Paging list of comment object</returns>
        [PublicAPI]
        public async Task<HasPaging<Comment>> GetAllVideoComments(long videoId, string[] fields = null, int? page = null, int? perPage = null)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.GetAsync(BuildGetUrl($"videos/{videoId}/comments", fields, page, perPage));

            return JsonConvert.DeserializeObject<HasPaging<Comment>>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Edit a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="video">Edit Video Body</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> UpdateEdit(long videoId, EditVideo video)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, BuildUrl($"videos/{videoId}"))
            {
                Content = new StringContent(JsonConvert.SerializeObject(video))
            };

            var apiResponse = await Client.SendAsync(request);

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Add a comment to a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="body">New Video Comment Body</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> AddCommentToVideo(long videoId, NewVideoComment body)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.PostAsync(BuildUrl($"videos/{videoId}/comments"), new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Add a reply to a comment on a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="commentId">Comment Id</param>
        /// <param name="body">New Video Comment Body</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> AddReplyCommentToVideo(long videoId, long commentId, NewVideoComment body)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.PostAsync(BuildUrl($"videos/{videoId}/comments/{commentId}/replies"), new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        [PublicAPI]
        public async Task<VimeoResponse> AddCreditToVideo(long videoId, Credit credit)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.PostAsync(BuildUrl($"videos/{videoId}/credits"), new StringContent(JsonConvert.SerializeObject(credit), Encoding.UTF8));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Create a new video thumbnail
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="body">New Video Thumbnail Body</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> CreateNewVideoThumbnail(long videoId, NewVideoThumbnail body)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.PostAsync(BuildUrl($"videos/{videoId}/pictures"), new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        #region Tags
        /// <summary>
        /// Get a video's tags
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="fields"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <returns>Paging List of Tag Object</returns>
        [PublicAPI]
        public async Task<HasPaging<Tag>> GetVideoTags(long videoId, string[] fields = null, int? page = null, int? perPage = null)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.GetAsync(BuildGetUrl($"/videos/{videoId}/tags", fields, page, perPage));

            return JsonConvert.DeserializeObject<HasPaging<Tag>>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Add tag to video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="tag">Tag you wanted added</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> AddTagToVideo(long videoId, string tag)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.PutAsync(BuildUrl($"videos/{videoId}/tags/{tag}"), new StringContent(tag));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Remove tag from video
        /// </summary>
        /// <param name="videoId">video Id</param>
        /// <param name="tag">Tag you want removed</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> RemoveTagToVideo(long videoId, string tag)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync(BuildUrl($"videos/{videoId}/tags/{tag}"));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }
        #endregion

        /// <summary>
        /// Disallow a user from viewing a private video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="userId">User Id</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> BlockUserAccessToVideo(long videoId, long userId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync(BuildUrl($"videos/{videoId}/privacy/users/{userId}"));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Disallow embedding of a video on a domain
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="domain">Domain</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> BlockDomainFromEmbeddingVideo(long videoId, string domain)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync(BuildUrl($"videos/{videoId}/privacy/domains/{domain}"));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Deletes a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> DeleteVideo(long videoId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync(BuildUrl($"videos/{videoId}"));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a comment from a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="commentId">Comment Id</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> DeleteVideoComment(long videoId, long commentId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync(BuildUrl($"videos/{videoId}/comments/{commentId}"));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a credit on a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="creditId">Credit Id</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> DeleteVideoCredit(long videoId, long creditId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync(BuildUrl($"videos/{videoId}/credits/{creditId}"));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a tag from a video
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="tag">Tag</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> DeleteTagFromVideo(long videoId, string tag)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync(BuildUrl($"videos/{videoId}/tags/{tag}"));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }

        /// <summary>
        /// Delete a video text track
        /// </summary>
        /// <param name="videoId">Video Id</param>
        /// <param name="textTrackId">Text Track Id</param>
        /// <returns>Vimeo Response</returns>
        [PublicAPI]
        public async Task<VimeoResponse> DeleteVideoTextTrack(long videoId, long textTrackId)
        {
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

            var apiResponse = await Client.DeleteAsync(BuildUrl($"videos/{videoId}/texttracks/{textTrackId}"));

            return JsonConvert.DeserializeObject<VimeoResponse>(await apiResponse.Content.ReadAsStringAsync());
        }
    }
}