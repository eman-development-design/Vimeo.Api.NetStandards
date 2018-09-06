using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Upload Video Model
    /// </summary>
    public class UploadVideo
    {
        /// <summary>
        /// Upload
        /// </summary>
        [JsonProperty("upload")]
        public Upload Upload { get; set; }

        /// <summary>
        /// Name Metadata
        /// </summary>
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Description Metadata
        /// </summary>
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Privacy Metadata
        /// </summary>
        [JsonProperty("privacy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Privacy Privacy { get; set; }
    }
}