using Design_patterns.FDM;

namespace Design_patterns.Printers
{
    class EnderPrinter : PrinterBase
    {
        public override string Model { get; protected set; }

        public EnderPrinter()
        {
            Model = "Ender";

            fdmBehaviour = new FdmPrinter();
        }
    }
}
