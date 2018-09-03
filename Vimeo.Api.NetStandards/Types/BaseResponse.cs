using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    public class BaseResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}