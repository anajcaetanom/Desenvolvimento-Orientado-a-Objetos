public class Projector
{
    public void On()
    {
        Console.WriteLine("Projector is on.");
    }

    public void Off()
    {
        Console.WriteLine("Projector is off.");
    }

    public void SetInput(string input)
    {
        Console.WriteLine($"Setting input to: {input}");
    }
}