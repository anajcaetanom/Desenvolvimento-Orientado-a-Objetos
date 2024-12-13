namespace strategy;

public interface IShippingStrategy
{
    float Calculate(float weight);
}