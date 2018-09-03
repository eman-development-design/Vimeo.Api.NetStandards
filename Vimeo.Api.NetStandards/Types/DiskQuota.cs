using System;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Disk Quota Type
    /// </summary>
    public class DiskQuota
    {
        /// <summary>
        /// Free Space
        /// </summary>
        [JsonProperty("free")]
        public long Free { get; set; }

        /// <summary>
        /// Max space allocated to account
        /// </summary>
        [JsonProperty("max")]
        public long Max { get; set; }

        /// <summary>
        /// Space Used
        /// </summary>
        [JsonProperty("used")]
        public long Used { get; set; }

        /// <summary>
        /// Showing
        /// </summary>
        [JsonProperty("showing", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Showing { get; set; }

        /// <summary>
        /// Reset Date
        /// </summary>
        [JsonProperty("reset_date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? ResetDate { get; set; }
    }
}