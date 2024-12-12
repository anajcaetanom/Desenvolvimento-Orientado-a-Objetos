namespace mediator;

class Program
{
    static void Main(string[] args)
    {
        var mediator = new ChatMediator();

        var user1 = new User("Alice", mediator);
        var user2 = new User("Kafka", mediator);
        
        user1.SendMessage("oii Kafka", user2);
        
        user2.SendMessage("oi todo mundo");
        
    }
}