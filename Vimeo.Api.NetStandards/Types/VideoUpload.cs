using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Video Upload Type
    /// </summary>
    public class VideoUpload
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Upload Link
        /// </summary>
        [JsonProperty("upload_link")]
        public string UploadLink { get; set; }

        /// <summary>
        /// HTML Form
        /// </summary>
        [JsonProperty("form")]
        public string Form { get; set; }

        /// <summary>
        /// Complete URI
        /// </summary>
        [JsonProperty("complete_uri")]
        public string CompleteUri { get; set; }

        /// <summary>
        /// Upload Approach
        /// </summary>
        [JsonProperty("approach")]
        public string Approach { get; set; }

        /// <summary>
        /// Upload File Size
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// Redirect URL
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}