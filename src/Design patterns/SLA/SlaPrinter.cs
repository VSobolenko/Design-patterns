using System;

namespace Design_patterns.SLA
{
    class SlaPrinter : ISla
    {
        public void PrintSLA()
        {
            Console.WriteLine("Standard printer with sla technology");
        }
    }
}
