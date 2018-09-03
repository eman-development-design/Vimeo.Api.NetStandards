using Newtonsoft.Json;

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