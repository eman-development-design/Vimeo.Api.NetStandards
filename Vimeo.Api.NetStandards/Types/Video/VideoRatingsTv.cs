using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Vimeo.Api.NetStandards.Constants;

namespace Vimeo.Api.NetStandards.Types.Video
{
    /// <summary>
    /// Video Ratings TV Type
    /// </summary>
    [PublicAPI]
    public class VideoRatingsTv
    {
        [JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TvReason Reason { get; set; }
    }
}