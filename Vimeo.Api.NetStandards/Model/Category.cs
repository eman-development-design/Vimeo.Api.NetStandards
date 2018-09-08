using System;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;
using Vimeo.Api.NetStandards.Types.MetaData;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Category Entity
    /// </summary>
    [PublicAPI]
    public class Category
    {
        /// <summary>
        /// Category URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Category Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Category Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Is Category Top Level?
        /// </summary>
        [JsonProperty("top_level")]
        public bool TopLevel { get; set; }

        [JsonProperty("pictures")]
        public Picture Pictures { get; set; }

        /// <summary>
        /// Last Video Featured Time
        /// </summary>
        [JsonProperty("last_video_featured_time")]
        public DateTime LastVideoFeaturedTime { get; set; }

        /// <summary>
        /// Parent Category
        /// </summary>
        [JsonProperty("parent")]
        public SubCategory Parent { get; set; }

        /// <summary>
        /// MetaData
        /// </summary>
        [JsonProperty("metadata")]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// SubCategories
        /// </summary>
        [JsonProperty("subcategories")]
        public SubCategory Subcategories { get; set; }

        /// <summary>
        /// Icon
        /// </summary>
        [JsonProperty("icon")]
        public Picture Icon { get; set; }

        /// <summary>
        /// Resource Key
        /// </summary>
        [JsonProperty("resource_key")]
        public string ResourceKey { get; set; }
    }
}