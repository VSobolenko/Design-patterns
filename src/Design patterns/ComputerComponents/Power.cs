using System;

namespace Design_patterns.ComputerComponents
{
    class Power
    {
        public bool IsEnable { get; private set; }

        public Power()
        {
            IsEnable = false;
        }

        public void Enable()
        {
            IsEnable = true;
            Console.WriteLine($"Power enable");
        }

        public void Disable()
        {
            IsEnable = false;
            Console.WriteLine($"Power disable");
        }
    }
}
