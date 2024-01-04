using ObserverPattern.Classes;

namespace ObserverPattern
{
    public class WeatherData : Observable
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void SetMeasurements (float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            _pressure = pressure;

            SetChanged();
            NotifyObservers();
        }

        public float GetTemperature()
        {
            return _temperature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}
