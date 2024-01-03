using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(100, 30, 100);
            weatherData.SetMeasurements(0, 0, 0);
            weatherData.SetMeasurements(50, 4, 20);
        }
    }
}