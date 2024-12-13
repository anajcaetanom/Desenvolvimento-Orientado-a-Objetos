using padrao_bridge.Interfaces;

namespace padrao_bridge.Colors;

public class RedColor : IColor 
{
    public void ApplyColor()
    {
        Console.WriteLine("Applying red color.");
    }
}