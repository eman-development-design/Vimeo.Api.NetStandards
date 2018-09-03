using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// User Entity
    /// </summary>
    public class User
    {
        /// <summary>
        /// User URI
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// User Full Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// User Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// User Location
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// User Bio
        /// </summary>
        [JsonProperty("bio")]
        public string Bio { get; set; }

        /// <summary>
        /// User Created time
        /// </summary>
        [JsonProperty("created_time")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// User Pictures
        /// </summary>
        [JsonProperty("pictures")]
        public Picture Pictures { get; set; }

        /// <summary>
        /// Websites
        /// </summary>
        [JsonProperty("websites")]
        public List<Website> Websites { get; set; }

        /// <summary>
        /// User MetaData
        /// </summary>
        [JsonProperty("metadata")]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// User Preferences
        /// </summary>
        [JsonProperty("preferences", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Preference Preferences { get; set; }

        /// <summary>
        /// Content Filter
        /// </summary>
        [JsonProperty("content_filter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> ContentFilter { get; set; }

        /// <summary>
        /// User Upload Quota
        /// </summary>
        [JsonProperty("upload_quota", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public UploadQuota UploadQuota { get; set; }

        /// <summary>
        /// Resource Key
        /// </summary>
        [JsonProperty("resource_key")]
        public string ResourceKey { get; set; }

        /// <summary>
        /// User Account Type
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }
    }
}