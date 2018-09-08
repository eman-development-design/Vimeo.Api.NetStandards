using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types.Video;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Stream Clip Video Type
    /// </summary>
    public class StreamClipVideo
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Owner
        /// </summary>
        [JsonProperty("owner")]
        public VideoOwner Owner { get; set; }
    }
}