namespace mediator;

public interface IMediator
{
    public void SendMessage(string message, User sender, User receiver);
}