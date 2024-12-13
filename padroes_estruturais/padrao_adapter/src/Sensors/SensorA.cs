namespace padrao_adapter.Sensors;

public class SensorA
{
    public float GetTemperatureInCelsius()
    {
        return new Random().Next(-10, 30);
    }
}