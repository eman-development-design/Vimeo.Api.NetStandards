using System.Runtime.Serialization;

namespace Vimeo.Api.NetStandards.Constants
{
    /// <summary>
    /// MPAA Rating Reason Enum
    /// </summary>
    public enum MpaaReason
    {
        [EnumMember(Value = "at")]
        DrugAlcoholUse,
        [EnumMember(Value = "bn")]
        BriefNudity,
        [EnumMember(Value = "n")]
        Nudity,
        [EnumMember(Value = "sl")]
        Language,
        [EnumMember(Value = "ss")]
        SexualSituations,
        [EnumMember(Value = "v")]
        Violence
    }
}