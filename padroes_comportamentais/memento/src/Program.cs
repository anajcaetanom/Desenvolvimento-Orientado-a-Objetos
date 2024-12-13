namespace memento;

class Program
{
    static void Main(string[] args)
    {
        var player = new Player
        {
            Position = 5,
            Health = 100
        };
        
        var caretaker = new Caretaker();
        
        caretaker.Save(player.SaveState());

        player.Position = 10;
        player.Health = 50;
        
        caretaker.Restore(player);

        Console.WriteLine(player.Position);
    }
}