using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Website Type
    /// </summary>
    public class Website
    {
        /// <summary>
        /// Website Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Website Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Website Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}