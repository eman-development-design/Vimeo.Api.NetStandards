using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Vimeo.Api.NetStandards.Constants
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDirection
    {
        [EnumMember(Value = "asc")]
        Ascending,
        [EnumMember(Value = "desc")]
        Descending
    }
}