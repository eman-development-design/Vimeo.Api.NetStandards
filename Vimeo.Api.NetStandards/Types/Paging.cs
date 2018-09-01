using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    public class Paging
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }
}