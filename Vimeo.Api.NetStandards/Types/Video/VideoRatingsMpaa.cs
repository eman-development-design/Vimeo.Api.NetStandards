using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Vimeo.Api.NetStandards.Constants;

namespace Vimeo.Api.NetStandards.Types.Video
{
    /// <summary>
    /// Video Ratings MPAA Type
    /// </summary>
    [PublicAPI]
    public class VideoRatingsMpaa
    {
        [JsonProperty("reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MpaaReason Reason { get; set; }
    }
}