using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Generic Select List Type
    /// </summary>
    [PublicAPI]
    public class SelectList
    {
        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}