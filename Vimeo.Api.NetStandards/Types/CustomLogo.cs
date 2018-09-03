using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Custom Logo Type
    /// </summary>
    public class CustomLogo
    {
        /// <summary>
        /// Active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Sticky
        /// </summary>
        [JsonProperty("sticky")]
        public bool Sticky { get; set; }
    }
}