using ObserverPattern.Interfaces.Subject;
using ObserverPattern.Interfaces.Observer;
using System;

namespace ObserverPattern.Classes
{
    public class Observable : ISubject
    {
        private readonly List<IObserver> _observers = new();

        private bool _changed;

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
                if (_changed)
                {
                    observer.Update(this);
                }
            });

            ClearChanged();
        }

        public void SetChanged()
        {
            _changed = true;
        }

        public void ClearChanged()
        {
            _changed = false;
        }
    }
}
