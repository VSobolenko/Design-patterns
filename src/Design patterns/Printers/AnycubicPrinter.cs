using Design_patterns.SLA;

namespace Design_patterns.Printers
{
    class AnycubicPrinter : PrinterBase
    {
        public override string Model { get; protected set; }

        public AnycubicPrinter()
        {
            Model = "Anycubic";

            slaBehaviour = new SlaPrinter();
        }
    }
}
