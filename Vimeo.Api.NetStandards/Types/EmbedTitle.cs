using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Embed Title Type
    /// </summary>
    public class EmbedTitle
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Owner
        /// </summary>
        [JsonProperty("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Portrait
        /// </summary>
        [JsonProperty("portrait")]
        public string Portrait { get; set; }
    }
}