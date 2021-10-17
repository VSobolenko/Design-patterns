using Design_patterns.ComputerComponents;
using System;

namespace Design_patterns
{
    class Computer
    {
        private readonly Power _power;
        private readonly OperatingSystemComputer _os;
        private readonly Programms _program;

        public Computer(Power power, OperatingSystemComputer os, Programms program)
        {
            _power = power;
            _os = os;
            _program = program;
        }

        public void EnableComputer()
        {
            if (_power.IsEnable)
            {
                Console.WriteLine("The computer is already on\n");
                return;
            }

            _power.Enable();
            _os.Enable();
            Console.WriteLine();
        }

        public void DisableComputer()
        {
            if (!_power.IsEnable)
            {
                Console.WriteLine("The computer is already off\n");
                return;
            }

            _os.Disable();
            _power.Disable();
            Console.WriteLine();
        }

        public void OpenProgramm(string name)
        {
            if (!_power.IsEnable || !_os.IsInitialized)
            {
                Console.WriteLine("Some kind of error has occurred\n");
                return;
            }
            _program.OpenProgramm(name);
            Console.WriteLine();
        }
    }
}
