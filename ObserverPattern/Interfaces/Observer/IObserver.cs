using ObserverPattern.Classes;

namespace ObserverPattern.Interfaces.Observer
{
    public interface IObserver
    {
        public void Update(Observable observable);
    }
}
