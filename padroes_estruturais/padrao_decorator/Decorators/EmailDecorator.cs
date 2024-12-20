public class EmailDecorator : INotification
{
    private readonly INotification _notification;

    public EmailDecorator(INotification notification)
    {
        _notification = notification;
    }

    public void Send(string message)
    {
        _notification.Send(message);
        Console.WriteLine("Sending email notification: " + message);
    }
}