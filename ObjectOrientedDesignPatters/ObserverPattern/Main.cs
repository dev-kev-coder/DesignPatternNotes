using ObserverPattern.Displays;

namespace ObserverPattern
{
    public class Main
    {
        public static void Run()
        {
            var weatherData = new WeatherData();

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(100, 30, 100);
            weatherData.SetMeasurements(0, 0, 0);
            weatherData.SetMeasurements(50, 4, 20);

            currentConditionsDisplay.Display();

            Console.WriteLine("Some Geological event happned OH NO!");

            weatherData.SetMeasurements(0, 0, 0);
            weatherData.SetMeasurements(0, 0, 0);
            weatherData.SetMeasurements(0, 0, 0);

            currentConditionsDisplay.Display();

        }
    }
}