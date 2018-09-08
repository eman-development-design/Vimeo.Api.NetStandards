using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Vimeo.Api.NetStandards.Constants;

namespace Vimeo.Api.NetStandards.Types.Video
{
    [PublicAPI]
    public class VideoSpatial
    {
        /// <summary>
        /// The 360 director timeline.
        /// </summary>
        [JsonProperty("director_timeline")]
        public List<DirectorTimeline> DirectorTimeline { get; set; }

        /// <summary>
        /// The 360 field of view: default 50, minimum 30, maximum 90.
        /// </summary>
        [JsonProperty("field_of_view")]
        public int FieldOfView { get; set; }

        /// <summary>
        /// The 360 spatial projection.
        /// </summary>
        [JsonProperty("projection")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SpatialProjection Projection { get; set; }

        /// <summary>
        /// The 360 spatial stereo format.
        /// </summary>
        [JsonProperty("stereo_format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SpatialStereoFormat StereoFormat { get; set; }
    }
}