using Alexa.NET.ConnectionTasks;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.PinConfirmation
{
    public class PinConfirmationInputConverter : IConnectionTaskConverter
    {
        public bool CanConvert(JObject jObject)
        {
            return jObject?.ContainsKey("requestedAuthenticationConfidenceLevel") ?? false;
        }

        public IConnectionTask Convert(JObject jObject)
        {
            return new PinConfirmationInput
            {
                RequestedAuthenticationConfidenceLevel =
                    JsonConvert.DeserializeObject<RequestedAuthenticationConfidenceLevel>(jObject.Value<JObject>("requestedAuthenticationConfidenceLevel").ToString())
            };
        }
    }
}