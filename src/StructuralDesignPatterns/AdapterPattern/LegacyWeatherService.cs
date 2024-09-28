namespace AdapterPattern
{
    public class LegacyWeatherService(ThirdPartyWeatherService weatherApi)
    {
        public string GetTemperature(string city, string country)
        {
            return weatherApi.GetTemperature(city, country);
        }

    }

}
