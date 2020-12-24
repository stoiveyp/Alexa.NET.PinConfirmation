using System;
using Xunit;

namespace Alexa.NET.PinConfirmation.Tests
{
    public class StartConnectionTests
    {
        [Fact]
        public void InputCreatesCorrectJSON()
        {
            Utility.AssertSerialization<PinConfirmationInput>("PinConfirmationInput.json");
        }

        [Fact]
        public void InputDefaultCreatesCorrectJSON()
        {
            Assert.True(Utility.CompareJson(PinConfirmationInput.Default(),"PinConfirmationInput.json"));
        }
    }
}
