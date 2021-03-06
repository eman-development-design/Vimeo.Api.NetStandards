using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Video Stats Type
    /// </summary>
    public class VideoStats
    {
        /// <summary>
        /// Play Count
        /// </summary>
        [JsonProperty("plays")]
        public long Plays { get; set; }
    }
}