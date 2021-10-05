using Design_patterns.Observable;
using System;

namespace Design_patterns.Observers
{
    class SouthPostSAI : IObserver, IPostSAI
    {
        private string _notifyMessage;

        public void Display()
        {
            Console.WriteLine("SouthPostSAI message: " + _notifyMessage);
        }

        public void Update(NewMessageArgs newMessage)
        {
            _notifyMessage = newMessage.Message;
            Display();
        }
    }
}
