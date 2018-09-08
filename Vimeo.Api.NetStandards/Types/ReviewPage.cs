using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Review Page Type
    /// </summary>
    public class ReviewPage
    {
        /// <summary>
        /// Is Active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("link", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Link { get; set; }
    }
}