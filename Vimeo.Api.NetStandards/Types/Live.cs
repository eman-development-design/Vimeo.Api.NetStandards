using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Live Type
    /// </summary>
    public class Live
    {
        /// <summary>
        /// Streaming
        /// </summary>
        [JsonProperty("streaming")]
        public bool Streaming { get; set; }

        /// <summary>
        /// Archived
        /// </summary>
        [JsonProperty("archived")]
        public bool Archived { get; set; }
    }
}