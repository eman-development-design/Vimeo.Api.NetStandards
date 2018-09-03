using Newtonsoft.Json;

namespace Vimeo.Api.NetStandards.Types
{
    /// <summary>
    /// Staff Pick Type
    /// </summary>
    public class StaffPick
    {
        /// <summary>
        /// Normal
        /// </summary>
        [JsonProperty("normal")]
        public bool Normal { get; set; }

        /// <summary>
        /// Best of the month
        /// </summary>
        [JsonProperty("best_of_the_month")]
        public bool BestOfTheMonth { get; set; }

        /// <summary>
        /// Best of the year
        /// </summary>
        [JsonProperty("best_of_the_year")]
        public bool BestOfTheYear { get; set; }

        /// <summary>
        /// Premiere
        /// </summary>
        [JsonProperty("premiere")]
        public bool Premiere { get; set; }
    }
}