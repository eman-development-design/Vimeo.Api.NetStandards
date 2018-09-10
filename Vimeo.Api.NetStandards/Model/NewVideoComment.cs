using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// New Video Comment Entity
    /// </summary>
    [PublicAPI]
    public class NewVideoComment
    {
        [JsonProperty("text")]
        public string CommentText { get; set; }
    }
}