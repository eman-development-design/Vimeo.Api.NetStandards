using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Vimeo.Api.NetStandards.Constants
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDirection
    {
        asc,
        desc
    }
}