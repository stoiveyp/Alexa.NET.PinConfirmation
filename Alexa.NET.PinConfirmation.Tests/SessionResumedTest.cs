using System;
using System.Collections.Generic;
using System.Text;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Xunit;

namespace Alexa.NET.PinConfirmation.Tests
{
    public class SessionResumedTest
    {
        [Fact]
        public void SessionResumeGeneratesJson()
        {
            //https://developer.amazon.com/en-US/docs/alexa/custom-skills/pin-confirmation-for-alexa-skills.html#sessionresumedrequest-format
            var cause = new SessionResumedRequestCause
            {
                Type = "ConnectionCompleted",
                Token = "Some connection token data",
                Status = new ConnectionStatus(200,"Successfully performed PIN confirmation"),
                Result = new PinConfirmationResumedResult
                {
                    Status = PinConfirmationStatus.NotAchieved,
                    Reason = PinConfirmationReason.VerificationMethodNotSetup
                }
            };
            Assert.True(Utility.CompareJson(cause,"ResumedSessionCause.json"));
        }

        [Fact]
        public void SessionResumeExtensionWorks()
        {
            var sessionResult = Utility.ExampleFileContent<SessionResumedRequestCause>("ResumedSessionCause.json");
            var pinResult  = new SessionResumedRequest {Cause = sessionResult}.GetPinResult();
            Assert.Equal(PinConfirmationStatus.Achieved,pinResult.Status);
            Assert.Equal(PinConfirmationReason.VerificationMethodNotSetup, pinResult.Reason);
        }
    }
}
