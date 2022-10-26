# Email sender API

## How to use:

<ul>
    <li> Get your SMTP password. If you use Gmail, you may get it <a href="https://myaccount.google.com/security">here.</a>
    <li> Open the appsettings.json file and replace your own configurations with placeholders.
    <br>
    <br>

```Json
"EmailConfiguration":
{
  "From": "your email",
  "SmtpServer": "smtp.gmail.com",
  "Port": 465,
  "Username": "your email",
  "Password": "app settings password"
}
```

<li> And API is ready to run

</ul>

Our API's query string looks like this one below:
```
https://localhost:7166/SendEmail?subject=Test%20Email&to=johndoe%40gmail.com&mailBody=This%20message%20was%20sent%20from%20Email%20Sender%20API
```


So, you need to convert normal string to API query string. So, you may use the code below to produce query string in C# :

```C#
using System.Web;
var requestString = HttpUtility.ParseQueryString("johndoe@gmail.com");    
```
<hr>
Feel free to message <a href="https://t.me/muhammaddiyor_imomnazarov">my Telegram </a> about any issues or questions. 
And, do not forget to star this repository 😉