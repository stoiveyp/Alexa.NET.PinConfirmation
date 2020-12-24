using System;
using System.Collections.Generic;
using Alexa.NET.ConnectionTasks;
using Alexa.NET.Request.Type;
using Alexa.NET.Response;
using Alexa.NET.Response.Converters;
using Alexa.NET.Response.Directive;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.PinConfirmation
{
    public static class PInConfirmationExtensions
    {
        public static void AddPinConfirmation()
        {
            throw new NotImplementedException("Not able to wire up until PR is accepted");
        }

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
