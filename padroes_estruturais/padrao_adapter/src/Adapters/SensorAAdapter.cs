using padrao_adapter.Interfaces;
using padrao_adapter.Sensors;

namespace padrao_adapter.Adapters;

public class SensorAAdapter : ITemperatureSensor
{
    private readonly SensorA _sensorA = new();

    public float ReadTemperature()
    {
        return _sensorA.GetTemperatureInCelsius();
    }
}