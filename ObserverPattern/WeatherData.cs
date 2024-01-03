using ObserverPattern.Interfaces.Subject;
using ObserverPattern.Interfaces.Observer;
 
namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void RegisterObserver(IObserver observer)
        {

        }

        public void RemoveObserver(IObserver observer)
        {

        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer =>
            {
                observer.Update(_temperature, _humidity, _pressure);
            });
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements (float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;
        }
    }
}
