using System;

namespace Design_patterns.ComputerComponents
{
    class OperatingSystemComputer
    {
        public string Name { get; private set; }
        public bool IsInitialized { get; private set; }

        public OperatingSystemComputer(string name)
        {
            Name = name;
        }

        public void Enable()
        {
            IsInitialized = true;
            Console.WriteLine($"OS {Name} initialized ");
        }

        public void Disable()
        {
            IsInitialized = false;
            Console.WriteLine($"OS {Name} off");
        }
    }
}
