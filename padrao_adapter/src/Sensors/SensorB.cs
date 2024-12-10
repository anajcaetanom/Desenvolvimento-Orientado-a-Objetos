namespace padrao_adapter.Sensors;

public class SensorB
{
    public float ObtenerTemperaturaEnCentigrados()
    {
        return new Random().Next(-10, 30);
    }
}