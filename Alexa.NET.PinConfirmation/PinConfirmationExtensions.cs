using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Alexa.NET.Response.Directive;
using Newtonsoft.Json;

namespace Alexa.NET.PinConfirmation
{
    public static class PInConfirmationExtensions
    {
        public static SkillResponse AddPinConfirmation(this SkillResponse response, string token)
        {
            response.Response.Directives.Add(new StartConnectionDirective(PinConfirmationInput.Default(),token));
            return response;
        }

        public static PinConfirmationResumedResult GetPinResult(this SessionResumedRequest request)
        {
            return JsonConvert.DeserializeObject<PinConfirmationResumedResult>(JsonConvert.SerializeObject(request.Cause.Result));
        }
    }
}
