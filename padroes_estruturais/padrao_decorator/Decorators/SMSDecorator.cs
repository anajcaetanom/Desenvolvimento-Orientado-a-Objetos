public class SMSDecorator : INotification
{
    private readonly INotification _notification;

    public SMSDecorator(INotification notification)
    {
        _notification = notification;
    }

    public void Send(string message)
    {
        _notification.Send(message);
        Console.WriteLine("Sending SMS notification: " + message);
    }
}