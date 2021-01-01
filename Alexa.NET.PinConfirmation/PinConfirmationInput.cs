using System.Linq;
using Alexa.NET.ConnectionTasks;
using Alexa.NET.Response.Converters;
using Newtonsoft.Json;

namespace Alexa.NET.PinConfirmation
{
    public class PinConfirmationInput:IConnectionTask
    {
        public const string AssociatedUri = "connection://AMAZON.VerifyPerson/2";
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

        public string ConnectionUri => AssociatedUri;

        public static void AddToConnectionTask()
        {
            if (!ConnectionTaskConverter.ConnectionTaskConverters.OfType<PinConfirmationInputConverter>().Any())
            {
                ConnectionTaskConverter.ConnectionTaskConverters.Add(new PinConfirmationInputConverter());
            }
        }
    }
}
