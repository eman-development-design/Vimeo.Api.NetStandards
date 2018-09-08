using System.Runtime.Serialization;

namespace Vimeo.Api.NetStandards.Constants
{
    /// <summary>
    /// 360 Spatial Stereo Format Enum
    /// </summary>
    public enum SpatialStereoFormat
    {
        [EnumMember(Value = "left-right")]
        LeftRight,
        [EnumMember(Value = "mono")]
        Mono,
        [EnumMember(Value = "top-bottom")]
        TopBottom
    }
}