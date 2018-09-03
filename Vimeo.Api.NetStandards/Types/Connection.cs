using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Connection Type
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        [JsonProperty("options")]
        public List<string> Options { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [JsonProperty("total", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Total { get; set; }
    }
}