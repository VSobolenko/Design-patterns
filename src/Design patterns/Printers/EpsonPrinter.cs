namespace Design_patterns.Printers
{
    class EpsonPrinter : PrinterBase
    {
        public override string Model { get; protected set; }

        public EpsonPrinter()
        {
            Model = "Epson";

            diskBehaviour = new Disk.ColorPrint();
        }
    }
}
