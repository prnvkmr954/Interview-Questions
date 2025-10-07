#region Implementation With Loose Coupling With DIP

class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine(message);
    }
}

class NotificationService
{
    private readonly IMessageService _service;
    public NotificationService(IMessageService service)
    {
        _service = service;
    }

    public void Notify()
    {
        _service.SendMessage("Hello There");
    }
}


interface IMessageService
{
    void SendMessage(string message);
}


#endregion

#region Implementation With Tight Coupling Without DIP

class NewEmailService()
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

class NewNotificationService
{
    private NewEmailService emailService = new NewEmailService();

    public void SendEmail()
    {
        emailService.SendEmail("Hello User");
    }
}


#endregion