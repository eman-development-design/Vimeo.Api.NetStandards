using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Tag Entity
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Tag Uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Tag Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [JsonProperty("tag")]
        public string TagValue { get; set; }

        /// <summary>
        /// Canonical
        /// </summary>
        [JsonProperty("canonical")]
        public string Canonical { get; set; }

        [JsonProperty("metadata")]
        public MetaData MetaData { get; set; }
    }
}