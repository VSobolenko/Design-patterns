using Design_patterns.Paper;

namespace Design_patterns.Printers
{
    class HPPrinter : PrinterBase
    {
        public override string Model { get; protected set; }

        public HPPrinter()
        {
            Model = "HP";

            paperBehaviour = new BlackAndWhitePrint();
        }
    }
}
