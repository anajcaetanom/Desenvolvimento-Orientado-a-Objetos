namespace strategy;

public class ExpressShipping : IShippingStrategy
{
    public float Calculate(float weight)
    {
        return weight * 0.25f; 
    }
}