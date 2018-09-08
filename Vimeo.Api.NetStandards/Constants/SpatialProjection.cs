using System.Runtime.Serialization;

namespace Vimeo.Api.NetStandards.Constants
{
    /// <summary>
    /// 360 Spatial Projection Enum
    /// </summary>
    public enum SpatialProjection
    {
        [EnumMember(Value = "cubical")]
        Cubical,
        [EnumMember(Value = "cylindrical")]
        Cylindrical,
        [EnumMember(Value = "dome")]
        Dome,
        [EnumMember(Value = "equirectangular")]
        Equirectangular,
        [EnumMember(Value = "pyramid")]
        Pyramid
    }
}