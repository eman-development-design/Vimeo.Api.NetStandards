using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Quota Type
    /// </summary>
    public class Quota
    {
        /// <summary>
        /// HD
        /// </summary>
        [JsonProperty("hd")]
        public bool Hd { get; set; }

        /// <summary>
        /// SD
        /// </summary>
        [JsonProperty("sd")]
        public bool Sd { get; set; }
    }
}