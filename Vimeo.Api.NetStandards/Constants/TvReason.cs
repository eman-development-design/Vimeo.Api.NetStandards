using System.Runtime.Serialization;

namespace Vimeo.Api.NetStandards.Constants
{
    /// <summary>
    /// TV Rating Reason Enum
    /// </summary>
    public enum TvReason
    {
        [EnumMember(Value = "d")]
        Dialogue,
        [EnumMember(Value = "fv")]
        FantasyViolence,
        [EnumMember(Value = "l")]
        Language,
        [EnumMember(Value = "ss")]
        SexualSituations,
        [EnumMember(Value = "v")]
        Violence
    }
}