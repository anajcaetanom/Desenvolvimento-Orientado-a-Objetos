namespace strategy;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new ShippingCalculator(new EconomyShipping());
        Console.WriteLine(calculator.Calculate(100));
        
        calculator.SetStrategy(new ExpressShipping());
        Console.WriteLine(calculator.Calculate(100));
    }
}