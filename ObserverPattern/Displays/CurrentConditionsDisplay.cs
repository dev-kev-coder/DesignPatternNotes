using ObserverPattern.Interfaces.Display;
using ObserverPattern.Interfaces.Observer;
using ObserverPattern.Interfaces.Subject;

namespace ObserverPattern.Displays
{
    public class CurrentConditionsDisplay : IDisplay, IObserver
    {
        private float _temperature;
        private float _humidity;
        private readonly ISubject _weatherData;

        public CurrentConditionsDisplay (ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update (float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }
    }
}
