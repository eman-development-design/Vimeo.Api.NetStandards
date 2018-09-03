using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Picture Type
    /// </summary>
    public class Picture
    {
        /// <summary>
        /// Picture Uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Is picture active?
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Picture Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Picture Sizes
        /// </summary>
        [JsonProperty("sizes")]
        public List<Size> Sizes { get; set; }

        /// <summary>
        /// Resource Key
        /// </summary>
        [JsonProperty("resource_key")]
        public string ResourceKey { get; set; }
    }
}