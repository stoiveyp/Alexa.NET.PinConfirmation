using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Alexa.NET.PinConfirmation
{
    public class PinConfirmationResumedResult
    {
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PinConfirmationStatus Status { get; set; }

        [JsonProperty("reason",NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public PinConfirmationReason Reason { get; set; }
    }
}
