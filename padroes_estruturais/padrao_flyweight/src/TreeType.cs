public class TreeType
{
    public string Texture { get; }
    public string Color { get; }

    public TreeType(string texture, string color)
    {
        Texture = texture;
        Color = color;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Rendering tree of color {Color} and texture {Texture} at ({x}, {y})");
    }
}