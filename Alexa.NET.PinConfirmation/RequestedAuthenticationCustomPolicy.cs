using Newtonsoft.Json;

namespace Alexa.NET.PinConfirmation
{
    public class RequestedAuthenticationCustomPolicy
    {
        [JsonProperty("policyName")]
        public string PolicyName { get; set; }
    }
}