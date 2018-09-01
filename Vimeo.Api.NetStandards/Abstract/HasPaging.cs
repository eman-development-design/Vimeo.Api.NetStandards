using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;

namespace Vimeo.Api.NetStandards.Abstract
{
    public class HasPaging<T> where T : class
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }
}