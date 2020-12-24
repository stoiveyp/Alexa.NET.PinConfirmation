using System.Runtime.Serialization;

namespace Alexa.NET.PinConfirmation
{
    public enum PinConfirmationReason
    {
        [EnumMember(Value="ACCOUNT_LOCKOUT")]
        AccountLockout,
        [EnumMember(Value="VERIFICATION_METHOD_NOT_SETUP")]
        VerificationMethodNotSetup,
        [EnumMember(Value="NOT_MATCH")]
        NotMatch
    }
}