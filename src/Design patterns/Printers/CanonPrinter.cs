namespace Design_patterns.Printers
{
    class CanonPrinter : PrinterBase
    {
        public override string Model { get; protected set; }

        public CanonPrinter()
        {
            Model = "Canon";

            paperBehaviour = new Paper.ColorPrint();
            diskBehaviour = new Disk.ColorPrint();
        }
    }
}
