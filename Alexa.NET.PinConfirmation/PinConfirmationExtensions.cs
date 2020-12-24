using System;
using System.Collections.Generic;
using Alexa.NET.ConnectionTasks;
using Alexa.NET.Response;
using Alexa.NET.Response.Converters;
using Alexa.NET.Response.Directive;

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
    }
}
