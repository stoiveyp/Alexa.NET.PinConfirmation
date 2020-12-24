using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Alexa.NET.PinConfirmation
{
    public class PinConfirmationInput
    {
        [JsonProperty("requestedAuthenticationConfidenceLevel")]
        public RequestedAuthenticationConfidenceLevel RequestedAuthenticationConfidenceLevel { get; set; }

        public static PinConfirmationInput Default()
        {
            return new()
            {
                RequestedAuthenticationConfidenceLevel = new()
                {
                    Level = 400,
                    CustomPolicy = new() {PolicyName = "VOICE_PIN"}
                }
            };
        }
    }
}
