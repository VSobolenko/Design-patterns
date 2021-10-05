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
        private delegate void NewMessageEventHandler(NewMessageArgs newMessage);
        private event NewMessageEventHandler MessageChanged;

        public void AddObserver(IObserver observer)
        {
            MessageChanged += observer.Update;
        }

        public void RemoveObserver(IObserver observer)
        {
            MessageChanged -= observer.Update;
        }

        public void NotifyObservers()
        {
            var randomInfo = GetNewMessage();

            MessageChanged?.Invoke(randomInfo);
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
