namespace mediator;

public class User
{
    public string Name { get; }
    private readonly IMediator _mediator;

    public User(string name, IMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public void SendMessage(string message, User receiver = null)
    {
        _mediator.SendMessage(message, this, receiver);
    }
}