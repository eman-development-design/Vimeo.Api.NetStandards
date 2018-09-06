using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Model
{
    public class Upload
    {
        [JsonProperty("approach")]
        public string Approach { get; set; }

        [JsonProperty("size", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Size { get; set; }

        [JsonProperty("redirect_url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        [JsonProperty("link", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Link { get; set; }
    }
}