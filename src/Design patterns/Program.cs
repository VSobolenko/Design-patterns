using Design_patterns.Observable;
using Design_patterns.Observers;
using System;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandCenter = new CommandCenterSAI();
            var centralPost = new CentralPostSAI();
            var eastPost = new EastPostSAI();
            var southPost = new SouthPostSAI();

            commandCenter.AddObserver(centralPost);
            commandCenter.AddObserver(eastPost);
            commandCenter.AddObserver(southPost);

            commandCenter.NotifyObservers();
            Console.WriteLine();

            commandCenter.RemoveObserver(southPost);

            commandCenter.NotifyObservers();
        }
    }
}
