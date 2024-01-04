using ObserverPattern.Interfaces.Observer;

namespace ObserverPattern.Interfaces.Subject
{
    public interface ISubject
    {
        public string RegisterObserver(IObserver observer);
        public string RemoveObserver(IObserver observer);
        public void NotifyObservers();
        public void SetChanged();
        public void ClearChanged();
    }
}
