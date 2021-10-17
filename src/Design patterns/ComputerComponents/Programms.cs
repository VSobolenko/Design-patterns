using System;

namespace Design_patterns.ComputerComponents
{
    class Programms
    {
        public void OpenProgramm(string name)
        {
            Console.WriteLine($"The pogramm {name} is open");
        }

        public void CloseProgramm(string name)
        {
            Console.WriteLine($"The pogramm {name} is close");
        }
    }
}
