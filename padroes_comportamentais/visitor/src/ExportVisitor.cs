namespace visitor;

public class ExportVisitor : IVisitor
{
    public void Visit(ElementA elementA)
    {
        Console.WriteLine("Exporting ElementA...");
    }

    public void Visit(ElementB elementB)
    {
        Console.WriteLine("Exporting ElementB...");
    }
}