namespace interpreter;

class Program
{
    static void Main(string[] args)
    {
        var expression = new AddExpression(
            new NumberExpression(5),
            new SubtractExpression(
                new NumberExpression(10), new NumberExpression(3))
        );

        Console.WriteLine(expression.Interpret());
    }
}