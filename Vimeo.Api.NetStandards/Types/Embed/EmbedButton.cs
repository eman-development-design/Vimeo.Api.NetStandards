using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types.Embed
{
    /// <summary>
    /// Embed Button Type
    /// </summary>
    public class EmbedButton
    {
        /// <summary>
        /// Like Button
        /// </summary>
        [JsonProperty("like")]
        public bool Like { get; set; }

        /// <summary>
        /// Watch Later Button
        /// </summary>
        [JsonProperty("watchlater")]
        public bool WatchLater { get; set; }

        /// <summary>
        /// Share Button
        /// </summary>
        [JsonProperty("share")]
        public bool Share { get; set; }

        /// <summary>
        /// Embed Button
        /// </summary>
        [JsonProperty("embed")]
        public bool Embed { get; set; }

        /// <summary>
        /// HD Button
        /// </summary>
        [JsonProperty("hd")]
        public bool Hd { get; set; }

        /// <summary>
        /// Fullscreen Button
        /// </summary>
        [JsonProperty("fullscreen")]
        public bool Fullscreen { get; set; }

        /// <summary>
        /// Scaling Button
        /// </summary>
        [JsonProperty("scaling")]
        public bool Scaling { get; set; }
    }
}