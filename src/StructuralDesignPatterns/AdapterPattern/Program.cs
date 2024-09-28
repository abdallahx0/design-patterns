
using AdapterPattern;

ThirdPartyWeatherService thirdPartyWeatherService = new ThirdPartyWeatherService();
LegacyWeatherService legacyWeatherService = new LegacyWeatherService(thirdPartyWeatherService);
WeatherServiceAdaptee weatherServiceAdaptee = new WeatherServiceAdaptee(legacyWeatherService);
TemperatureDate result = weatherServiceAdaptee.GetTemperature(111, 111);

Console.WriteLine(result.GetTemperatureData());