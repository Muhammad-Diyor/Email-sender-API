namespace EmailSender.Services;

public interface IEmailSender
{
    void SendEmail(Message message);
}