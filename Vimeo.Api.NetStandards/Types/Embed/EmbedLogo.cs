using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types.Embed
{
    /// <summary>
    /// Embed Logo Type
    /// </summary>
    public class EmbedLogo
    {
        /// <summary>
        /// Vimeo Logo
        /// </summary>
        [JsonProperty("vimeo")]
        public bool Vimeo { get; set; }

        /// <summary>
        /// Custom Logo
        /// </summary>
        [JsonProperty("custom")]
        public CustomLogo Custom { get; set; }
    }
}