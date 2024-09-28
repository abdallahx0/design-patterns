namespace AdapterPattern
{
    public class ThirdPartyWeatherService
    {
        public string GetTemperature(string city, string country)
        {
            Console.WriteLine("Fetching temperature data ...");
            return "Temperature Data returned in XML Format...";
        }
    }
}
