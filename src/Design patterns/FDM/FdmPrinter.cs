using System;

namespace Design_patterns.FDM
{
    class FdmPrinter : IFdm
    {
        public void PrintFDM()
        {
            Console.WriteLine("Standard printer with fdm technology");
        }
    }
}
