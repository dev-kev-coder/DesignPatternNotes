using ObserverPattern.Interfaces.Observer;

namespace ObserverPattern.Interfaces.Subject
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObservers();

    }
}
