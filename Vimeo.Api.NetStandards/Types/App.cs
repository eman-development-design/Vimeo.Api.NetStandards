using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// App Type
    /// </summary>
    public class App
    {
        /// <summary>
        /// App Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// App URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}