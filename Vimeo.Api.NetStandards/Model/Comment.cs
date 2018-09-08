using System;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types.MetaData;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Comment Entity
    /// </summary>
    [PublicAPI]
    public class Comment
    {
        /// <summary>
        /// Comment URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Comment Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Comment Text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Date comment was created
        /// </summary>
        [JsonProperty("created_on")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// User Object
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }

        /// <summary>
        /// Comment Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// Resource Key
        /// </summary>
        [JsonProperty("resource_key")]
        public string ResourceKey { get; set; }
    }
}