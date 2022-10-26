namespace EmailSender.Source.Services;

public interface IEmailSender
{
    void SendEmail(Message message);
}