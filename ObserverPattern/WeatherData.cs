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

        public string RegisterObserver(IObserver observer)
        {
            var indexOfObserver = _observers.IndexOf(observer);

            if (indexOfObserver != -1) return "Observer has alrady been added";

            _observers.Add(observer);

            return "Observer added successfully";
        }

        public string RemoveObserver(IObserver observer)
        {
            var indexOfObserver = _observers.IndexOf(observer);

            if (indexOfObserver == -1) return "Observer Does not exist";

            _observers.RemoveAt(indexOfObserver);

            return "Observer removed successfully";
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
            MeasurementsChanged();
        }
    }
}
