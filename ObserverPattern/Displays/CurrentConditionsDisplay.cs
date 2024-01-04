using ObserverPattern.Classes;
using ObserverPattern.Interfaces.Display;
using ObserverPattern.Interfaces.Observer;

namespace ObserverPattern.Displays
{
    public class CurrentConditionsDisplay : IDisplay, IObserver
    {
        private float _temperature;
        private float _humidity;
        private readonly Observable _weatherData;

        public CurrentConditionsDisplay (Observable weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update (Observable observable)
        {
            if (observable is WeatherData weatherData)
            {
                _temperature = weatherData.GetTemperature();
                _humidity = weatherData.GetHumidity();
            }
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }
    }
}
