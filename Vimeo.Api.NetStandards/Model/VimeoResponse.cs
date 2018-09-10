using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Vimeo Response Entity
    /// </summary>
    [PublicAPI]
    public class VimeoResponse
    {
        /// <summary>
        /// Error Message
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Developer-specific Message
        /// </summary>
        [JsonProperty("developer_message")]
        public string DeveloperMessage { get; set; }

        /// <summary>
        /// Error Code
        /// </summary>
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }
    }
}