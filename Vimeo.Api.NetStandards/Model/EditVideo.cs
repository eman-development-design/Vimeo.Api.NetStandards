using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Vimeo.Api.NetStandards.Types;
using Vimeo.Api.NetStandards.Types.Video;

namespace Vimeo.Api.NetStandards.Model
{
    /// <summary>
    /// Edit Video Entity
    /// </summary>
    [PublicAPI]
    public class EditVideo
    {
        /// <summary>
        /// Content Rating
        /// </summary>
        [JsonProperty("content_rating")]
        public List<string> ContentRating { get; set; }

        /// <summary>
        /// Video Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Video Embed Properties
        /// </summary>
        [JsonProperty("embed")]
        public Embed Embed { get; set; }

        /// <summary>
        /// License
        /// </summary>
        [JsonProperty("license")]
        public string License { get; set; }

        /// <summary>
        /// The video's default language.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Video Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Privacy
        /// </summary>
        [JsonProperty("privacy")]
        public Privacy Privacy { get; set; }

        [JsonProperty("ratings")]
        public VideoRatings Ratings { get; set; }

        /// <summary>
        /// Review Page
        /// </summary>
        [JsonProperty("review_page")]
        public ReviewPage ReviewPage { get; set; }

        /// <summary>
        /// 360 Video Settings
        /// </summary>
        [JsonProperty("spatial")]
        public VideoSpatial Spatial { get; set; }
    }
}