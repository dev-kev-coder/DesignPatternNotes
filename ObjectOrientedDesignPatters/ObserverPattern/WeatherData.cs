using ObserverPattern.Classes;

namespace ObserverPattern
{
    public class WeatherData : Observable
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public float Temperature { get { return _temperature; } set {  _temperature = value; } }
        public float Humidity { get { return _humidity; } set { _humidity = value; } }
        public float Pressure { get { return _pressure; } set { _pressure = value; } }

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
