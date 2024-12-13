namespace strategy;

public class ShippingCalculator
{
    private IShippingStrategy _strategy;

    public ShippingCalculator(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public float Calculate(float weight)
    {
        return _strategy.Calculate(weight); 
    }
}