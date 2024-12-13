namespace strategy;

public class EconomyShipping : IShippingStrategy
{
    public float Calculate(float weight)
    {
        return weight * 0.1f; 
    }
}