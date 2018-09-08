using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Privacy Type
    /// </summary>
    public class Privacy
    {
        /// <summary>
        /// View Privacy
        /// </summary>
        [JsonProperty("view")]
        public string View { get; set; }

        /// <summary>
        /// Embed Privacy
        /// </summary>
        [JsonProperty("embed")]
        public string Embed { get; set; }

        /// <summary>
        /// Download
        /// </summary>
        [JsonProperty("download")]
        public bool Download { get; set; }

        /// <summary>
        /// Add
        /// </summary>
        [JsonProperty("add", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Add { get; set; }

        /// <summary>
        /// Comment Privacy
        /// </summary>
        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comments { get; set; }
    }
}