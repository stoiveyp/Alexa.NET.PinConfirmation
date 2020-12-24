using System;
using Alexa.NET.ConnectionTasks;
using Alexa.NET.Response.Directive;
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

        [Fact]
        public void IConnectionTaskWiredSuccessfully()
        {
            PInConfirmationExtensions.AddPinConfirmation();
            Utility.AssertSerialization<IConnectionTask>("PinConfirmationInput.json");
        }

        [Fact]
        public void ConnectionTaskDirectiveExtensionAddsCorrectly()
        {
            var token = Guid.NewGuid().ToString("N");
            var output = ResponseBuilder.Empty().AddPinConfirmation(token);
            var scd = Assert.IsType<StartConnectionDirective>(Assert.Single(output.Response.Directives));
            Assert.Equal(token, scd.Token);
            Assert.Equal(PinConfirmationInput.AssociatedUri,scd.Uri);
            Assert.IsType<PinConfirmationInput>(scd.Input);
        }
    }
}
