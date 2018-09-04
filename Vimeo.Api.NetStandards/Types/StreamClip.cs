using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Stream Clip Type
    /// </summary>
    public class StreamClip
    {
        /// <summary>
        /// Video
        /// </summary>
        [JsonProperty("Video")]
        public StreamClipVideo Video { get; set; }
    }
}