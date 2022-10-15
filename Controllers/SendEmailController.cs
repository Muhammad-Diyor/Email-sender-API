using System.Web;
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
    public IActionResult Get([FromQuery]string subject, [FromQuery]string to, [FromQuery]string mailBody)
    {
        var message = new Message(new string[]  {$"{to}"}, subject, mailBody);
        _emailSender.SendEmail(message);
        return Ok($"{to} == {mailBody}");
    }
}