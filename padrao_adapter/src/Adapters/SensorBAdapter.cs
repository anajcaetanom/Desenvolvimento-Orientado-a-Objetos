using padrao_adapter.Interfaces;
using padrao_adapter.Sensors;

namespace padrao_adapter.Adapters;

public class SensorBAdapter : ITemperatureSensor
{
    private readonly SensorB _sensorB = new();

    public float ReadTemperature()
    {
        return _sensorB.ObtenerTemperaturaEnCentigrados();
    }
}