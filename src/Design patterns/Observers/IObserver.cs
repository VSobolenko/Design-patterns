using Design_patterns.Observable;

namespace Design_patterns.Observers
{
    public interface IObserver
    {
        void Update(NewMessageArgs newMessage);
    }
}
