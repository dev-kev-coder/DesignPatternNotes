using ObserverPattern.Interfaces.Display;
using ObserverPattern.Interfaces.Observer;

namespace ObserverPattern.Displays
{
    public class CurrentConditionsDisplay : IDisplay, IObserver
    {
        public void Display()
        {

        }

        public void Update (float temp, float humidity, float pressure)
        {

        }
    }
}
