using padrao_adapter.Sensors;

namespace padrao_adapter.Adapters;

public class SensorCAdapter
{
    private readonly SensorC _sensorC = new();

    public float ReadTemperature()
    {
        return _sensorC.FetchTempC();
    }
}