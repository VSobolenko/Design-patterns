using System;

namespace Design_patterns.SLA
{
    class AcceleratedPrinter : ISla
    {
        public void PrintSLA()
        {
            Console.WriteLine("SLA printer with accelerated Z axis");
        }
    }
}
