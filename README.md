##Send an SMS using Nexmo's Dot Net Client Library

First, open the 'App.config' file and add your credentials (API Key & API Secret):

```cs
<add key="Nexmo.api_key" value="NEXMOAPIKEY"/>
<add key="Nexmo.api_secret" value="NEXMOAPISECRET" />
```

Next, open 'Program.cs' and enter the Nexmo virtual number in the 'from' field (found in the customer dashboard under 'Numbers').
Enter the destination number in the 'to' field (the phone that will recieve the text)

```cs
var results = SMS.Send(new SMS.SMSRequest
{
    from = "",
    to = "",
    text = text
});
```

That's it! Run the program and enter the text you wish to send!