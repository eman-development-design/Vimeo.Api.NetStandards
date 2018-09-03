using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Model
{
    public class Upload
    {
        [JsonProperty("approach")]
        public string Approach { get; set; } = "tus";

        [JsonProperty("size")]
        public long Size { get; set; }
    }
}