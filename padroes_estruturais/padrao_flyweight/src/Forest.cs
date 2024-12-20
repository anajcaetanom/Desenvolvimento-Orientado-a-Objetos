public class Forest
{
    private readonly List<Tree> _trees = new List<Tree>();

    public void AddTree(string type, string texture, string color, int x, int y)
    {
        TreeType treeType = TreeFactory.GetTreeType(texture, color);
        Tree tree = new Tree(treeType, x, y);
        _trees.Add(tree);
    }

    public void Render()
    {
        foreach (var tree in _trees)
        {
            tree.Render();
        }
    }
}