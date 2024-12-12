namespace mediator;

public class ChatMediator : IMediator
{
    public void SendMessage(string message, User sender, User receiver)
    {
        if (receiver != null)
        {
            Console.WriteLine($"{sender.Name} to {receiver.Name}: {message}");
        }
        else
        {
            Console.WriteLine($"{sender.Name}: {message} (Broadcast)");
        }
    }
}