using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Meta Data Interaction Type
    /// </summary>
    public class MetaDataInteractions
    {
        /// <summary>
        /// Follow
        /// </summary>
        [JsonProperty("follow", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Interaction Follow { get; set; }

        /// <summary>
        /// Block
        /// </summary>
        [JsonProperty("block", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Interaction Block { get; set; }

        /// <summary>
        /// Report
        /// </summary>
        [JsonProperty("report", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Interaction Report { get; set; }

        /// <summary>
        /// Watch Later
        /// </summary>
        [JsonProperty("watchlater", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Interaction WatchLater { get; set; }

        /// <summary>
        /// Like
        /// </summary>
        [JsonProperty("like", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Interaction Like { get; set; }
    }
}