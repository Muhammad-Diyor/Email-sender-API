using EmailSender.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmailSender.Controllers;

[ApiController]
[Route("[controller]")]
public class SendEmailController : ControllerBase
{
    private readonly IEmailSender _emailSender;

    public SendEmailController(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }
    
    [HttpPost]
    [Route("{to}/{mailBody}")]
    public IActionResult Get(string to, string mailBody)
    {
        var message = new Message(new string[] {$"{to}"}, "Test email", $"{mailBody}");
        _emailSender.SendEmail(message);
        return Ok($"{to} == {mailBody}");
    }
}