using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Width Type
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Width
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Link with play button
        /// </summary>
        [JsonProperty("link_with_play_button")]
        public string LinkWithPlayButton { get; set; }
    }
}