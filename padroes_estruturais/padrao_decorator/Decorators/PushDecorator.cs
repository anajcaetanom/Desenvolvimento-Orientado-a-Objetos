public class PushDecorator : INotification
{
    private readonly INotification _notification;

    public PushDecorator(INotification notification)
    {
        _notification = notification;
    }

    public void Send(string message)
    {
        _notification.Send(message);
        Console.WriteLine("Sending push notification: " + message);
    }
}