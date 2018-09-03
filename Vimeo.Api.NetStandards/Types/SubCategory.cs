using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// SubCategory Type
    /// </summary>
    public class SubCategory
    {
        /// <summary>
        /// SubCategory URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// SubCategory Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// SubCategory Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}