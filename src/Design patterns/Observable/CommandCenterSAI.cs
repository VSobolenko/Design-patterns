using Design_patterns.Observers;
using System;
using System.Collections.Generic;

namespace Design_patterns.Observable
{
    public class NewMessageArgs
    {
        public NewMessageArgs(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }

    public class CommandCenterSAI : IObservable<IObserver>
    {
        private List<IObserver> _observers;

        /*
         * We can use event instead list

        private delegate void NewMessageEventHandler(NewMessageArgs newMessage);
        private event NewMessageEventHandler MessageChanged;

        */

        public CommandCenterSAI()
        {
            _observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);

            //MessageChanged += observer.Update;
        }

        public void NotifyObservers()
        {
            var randomInfo = GetNewMessage();

            foreach (var observer in _observers)
            {
                observer.Update(randomInfo);
            }

            //MessageChanged?.Invoke(randomInfo);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);

            //MessageChanged -= observer.Update;
        }

        public NewMessageArgs GetNewMessage()
        {
            Random randomContLetters = new Random();
            Random randomLetter = new Random();

            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            string randomWord = "";

            for (int i = 1; i <= randomContLetters.Next(1, 10); i++)
            {
                int letter_num = randomLetter.Next(0, letters.Length - 1);

                randomWord += letters[letter_num];
            }
            NewMessageArgs randomMessageArgs = new NewMessageArgs(randomWord);

            return randomMessageArgs;
        }
    }
}
