using Design_patterns.Printers;
using System;
using System.Collections.Generic;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PrinterBase> printers = new List<PrinterBase>();
            printers.Add(new UltimakerPrinter());
            printers.Add(new EnderPrinter());
            printers.Add(new AnycubicPrinter());
            printers.Add(new CanonPrinter());
            printers.Add(new HPPrinter());
            printers.Add(new EpsonPrinter());

            foreach (var printer in printers)
            {
                Console.WriteLine(printer.Model);
                printer.PrintPaper();
                printer.PrintDisk();
                printer.PrintFDM();
                printer.PrintSLA();

                Console.WriteLine();
            }
        }
    }
}
