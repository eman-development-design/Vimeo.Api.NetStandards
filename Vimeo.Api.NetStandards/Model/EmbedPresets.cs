using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;
using Vimeo.Api.NetStandards.Types.Embed;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Embed Presets Entity
    /// </summary>
    public class EmbedPresets
    {
        /// <summary>
        /// URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Settings
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public EmbedSettings Settings { get; set; }
    }
}