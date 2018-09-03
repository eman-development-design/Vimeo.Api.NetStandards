using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Embed Entity
    /// </summary>
    public class Embed
    {
        /// <summary>
        /// Embed Uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Embed Html
        /// </summary>
        [JsonProperty("html")]
        public string Html { get; set; }

        /// <summary>
        /// Embed Badges
        /// </summary>
        [JsonProperty("badges")]
        public EmbedBadge Badges { get; set; }

        /// <summary>
        /// Embed Buttons
        /// </summary>
        [JsonProperty("buttons")]
        public EmbedButton Buttons { get; set; }

        /// <summary>
        /// Logos
        /// </summary>
        [JsonProperty("logos")]
        public EmbedLogo Logos { get; set; }

        [JsonProperty("title")]
        public EmbedTitle Title { get; set; }

        /// <summary>
        /// Play Bar
        /// </summary>
        [JsonProperty("playbar")]
        public bool Playbar { get; set; }

        /// <summary>
        /// Volume
        /// </summary>
        [JsonProperty("volume")]
        public bool Volume { get; set; }

        /// <summary>
        /// Speed
        /// </summary>
        [JsonProperty("speed")]
        public bool Speed { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}