namespace AdapterPattern
{
    public interface IWeatherServiceAdapter
    {
        TemperatureDate GetTemperature(double longitude, double latitude);
    }
}
