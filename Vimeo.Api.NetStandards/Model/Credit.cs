using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Credit Entity
    /// </summary>
    [PublicAPI]
    public class Credit
    {
        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Role
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// User's Profile URI
        /// </summary>
        [JsonProperty("user_uri")]
        public string Uri { get; set; }
    }
}