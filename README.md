#Whatsapp webhook
Whatsapp Webhook is the .NET Core hook for whatsapp business. it allow you to intercept events on your Whatsapp Business Account using the Meta Developers service.


The first necessary condition for working with Whatsapp Webhook is that you need to run this service with HTTPS protocol.

Afterwards, you can configure an App on the Meta Developers dashboard, specifying the hook url and the token made by yourself.

Remeber to change your token in the code in Controllers/WebhookController.cs:
```csharp
14      if (mode == "subscribe" && token == "YOUR_VERIFICATION_TOKEN")
```

then rebuild the project
```powershell
dotnet build
```