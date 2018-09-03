using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Embed Badge Type
    /// </summary>
    public class EmbedBadge
    {
        /// <summary>
        /// HDR
        /// </summary>
        [JsonProperty("hdr")]
        public bool Hdr { get; set; }

        /// <summary>
        /// Live
        /// </summary>
        [JsonProperty("live")]
        public Live Live { get; set; }

        /// <summary>
        /// Staff Pick
        /// </summary>
        [JsonProperty("staff_pick")]
        public StaffPick StaffPick { get; set; }

        /// <summary>
        /// Video OnDemand
        /// </summary>
        [JsonProperty("vod")]
        public bool Vod { get; set; }

        /// <summary>
        /// Weekend Challenge
        /// </summary>
        [JsonProperty("weekend_challenge")]
        public bool WeekendChallenge { get; set; }
    }
}