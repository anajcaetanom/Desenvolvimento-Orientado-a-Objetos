using padrao_bridge.Interfaces;

namespace padrao_bridge.Colors;

public class BlueColor : IColor
{
    public void ApplyColor()
    {
        Console.WriteLine("Applying blue color.");
    }
}