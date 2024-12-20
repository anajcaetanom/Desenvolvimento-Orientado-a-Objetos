public class Tree
{
    public int X { get; set; }
    public int Y { get; set; }
    public TreeType TreeType { get; private set; }

    public Tree(TreeType treeType, int x, int y)
    {
        TreeType = treeType;
        X = x;
        Y = y;
    }

    public void Render()
    {
        Console.WriteLine($"Rendering tree at ({X}, {Y}) with texture {TreeType.Texture} and color {TreeType.Color}");
    }
}