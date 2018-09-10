using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    ///
    /// </summary>
    [PublicAPI]
    public class NewVideoThumbnail
    {
        [JsonProperty("active")]
        public bool DefaultThumbnail { get; set; }

        [JsonProperty("time")]
        private float Time { get; set; }
    }
}