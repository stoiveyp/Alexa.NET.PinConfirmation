using Newtonsoft.Json;

namespace Alexa.NET.PinConfirmation
{
    public class RequestedAuthenticationConfidenceLevel
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("customPolicy")]
        public RequestedAuthenticationCustomPolicy CustomPolicy { get; set; }
    }
}