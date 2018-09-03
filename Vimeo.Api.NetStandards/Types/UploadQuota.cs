using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Upload Quota Type
    /// </summary>
    public class UploadQuota
    {
        /// <summary>
        /// Space Quota
        /// </summary>
        [JsonProperty("space")]
        public DiskQuota Space { get; set; }

        /// <summary>
        /// Periodic Quota
        /// </summary>
        [JsonProperty("periodic")]
        public DiskQuota Periodic { get; set; }

        /// <summary>
        /// Lifetime Quota
        /// </summary>
        [JsonProperty("lifetime")]
        public DiskQuota LifeTime { get; set; }

        /// <summary>
        /// Quota
        /// </summary>
        [JsonProperty("quota")]
        public Quota Quota { get; set; }
    }
}