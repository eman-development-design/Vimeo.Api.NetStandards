using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types.Video;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Preference Type
    /// </summary>
    public class Preference
    {
        [JsonProperty("videos")]
        public VideoPreference Videos { get; set; }
    }
}