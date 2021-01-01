# Alexa.NET.PinConfirmation
Small helper library allowing Alexa.NET Skills to more easily access the Pin Confirmation functionality

## Add Support in code
place this in your initialisation/setup code and then interaction with pin confirmation can be performed by extension methods shown below

```csharp
PinConfirmationInput.AddToConnectionTask();
```

## Add pin confirmation to your response

```csharp
SkillResponse response = ...
response.AddPinConfirmation("[yourTokenHere]");
```

## Get information once skill is resumed

```csharp
if(skillRequest.Request is SessionResumedRequest sessionResumed)
{
  var result = sessionResumed.GetPinResult();
}
```