using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Director Timeline Type
    /// </summary>
    [PublicAPI]
    public class DirectorTimeline
    {
        /// <summary>
        /// The timeline pitch. This value must be between -90 and 90.
        /// </summary>
        [JsonProperty("pitch")]
        public float Pitch { get; set; }

        /// <summary>
        /// The timeline roll.
        /// </summary>
        [JsonProperty("roll")]
        public float Roll { get; set; }

        /// <summary>
        /// The 360 director timeline time code.
        /// </summary>
        [JsonProperty("time_code")]
        public float TimeCode { get; set; }

        /// <summary>
        /// The timeline yaw. This value must be between 0 and 360.
        /// </summary>
        [JsonProperty("yaw")]
        public float Yaw { get; set; }
    }
}