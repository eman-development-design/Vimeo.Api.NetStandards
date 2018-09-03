using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Interaction Type
    /// </summary>
    public class Interaction
    {
        /// <summary>
        /// URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        [JsonProperty("options", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Options { get; set; }

        /// <summary>
        /// Added
        /// </summary>
        [JsonProperty("added", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Added { get; set; }

        /// <summary>
        /// Added Time
        /// </summary>
        [JsonProperty("added_time", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime AddedTime { get; set; }

        /// <summary>
        /// Reason
        /// </summary>
        [JsonProperty("reason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Reason { get; set; }
    }
}