public class BaseNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending base notification: " + message);
    }
}