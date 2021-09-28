using System;

namespace Design_patterns.FDM
{
    class AcceleratedPrinter : IFdm
    {
        public void PrintFDM()
        {
            Console.WriteLine("FDM printer with accelerated axis mode");
        }
    }
}
