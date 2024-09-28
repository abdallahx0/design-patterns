namespace AdapterPattern
{
    public class WeatherServiceAdaptee(LegacyWeatherService legacyWeatherService) : IWeatherServiceAdapter
    {
        public TemperatureDate GetTemperature(double longitude, double latitude)
        {
            string temperatureDataInXML = legacyWeatherService.GetTemperature(GetCityOf(longitude, latitude), GetCountryOf(longitude, latitude));

            return ConvertXMLDataToJson(temperatureDataInXML);
        }

        private TemperatureDate ConvertXMLDataToJson(string xmlData)
        {
            Console.WriteLine("Converting...");
            return new TemperatureDate("Converted Data from XML into JSON");
        }

        private string GetCityOf(double longitude, double latitude)
        {
            Console.WriteLine("Extracting city of longitude: " + longitude + " and latitude: " + latitude);
            return "City";
        }

        private string GetCountryOf(double longitude, double latitude)
        {
            Console.WriteLine("Extracting country of longitude: " + longitude + " and latitude: " + latitude);
            return "Country";
        }
    }
}
