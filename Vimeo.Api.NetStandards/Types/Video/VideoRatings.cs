using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types.Video
{
    /// <summary>
    /// Video Ratings Type
    /// </summary>
    [PublicAPI]
    public class VideoRatings
    {
        [JsonProperty("mpaa")]
        public VideoRatingsMpaa Mpaa { get; set; }

        [JsonProperty("tv")]
        public VideoRatingsTv Tv { get; set; }
    }
}