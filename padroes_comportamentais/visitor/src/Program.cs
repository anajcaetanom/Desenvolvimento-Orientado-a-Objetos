namespace visitor;

class Program
{
    static void Main(string[] args)
    {
        var visitor = new ValidationVisitor();
        var elementA = new ElementA();
        elementA.Accept(visitor);
    }
}