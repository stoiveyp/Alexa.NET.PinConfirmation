﻿using System.Runtime.Serialization;

namespace Alexa.NET.PinConfirmation
{
    public enum PinConfirmationStatus
    {
        [EnumMember(Value="ACHIEVED")]
        Achieved,
        [EnumMember(Value="NOT_ACHIEVED")]
        NotAchieved,
        [EnumMember(Value="NOT_ENABLED")]
        NotEnabled
    }
}