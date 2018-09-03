using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Video Preference Type
    /// </summary>
    public class VideoPreference
    {
        [JsonProperty("privacy")]
        public Privacy Privacy { get; set; }
    }
}