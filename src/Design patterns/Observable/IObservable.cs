namespace Design_patterns.Observable
{
    public interface IObservable<T>
    {
        void AddObserver(T observer);
        void RemoveObserver(T observer);
        void NotifyObservers();
    }
}
