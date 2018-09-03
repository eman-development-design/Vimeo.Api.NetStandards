using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// MetaData Type
    /// </summary>
    public class MetaData
    {
        /// <summary>
        /// Connections
        /// </summary>
        [JsonProperty("connections")]
        public MetaDataConnection Connections { get; set; }

        /// <summary>
        /// Interactions
        /// </summary>
        [JsonProperty("interactions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MetaDataInteractions Interactions { get; set; }
    }
}