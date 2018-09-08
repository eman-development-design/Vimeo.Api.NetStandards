using JetBrains.Annotations;
using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types.MetaData;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Tag Entity
    /// </summary>
    [PublicAPI]
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

        /// <summary>
        /// Tag Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// Resource Key
        /// </summary>
        [JsonProperty("resource_key", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResourceKey { get; set; }
    }
}