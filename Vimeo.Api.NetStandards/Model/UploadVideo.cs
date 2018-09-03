using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Model
{
    public class UploadVideo
    {
        [JsonProperty("upload")]
        public Upload Upload { get; set; }
    }
}