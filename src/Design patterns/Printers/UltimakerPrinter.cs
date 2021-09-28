namespace Design_patterns.Printers
{
    class UltimakerPrinter : PrinterBase
    {
        public override string Model { get; protected set; }

        public UltimakerPrinter()
        {
            Model = "Ultimaker";

            fdmBehaviour = new FDM.AcceleratedPrinter();
            slaBehaviour = new SLA.AcceleratedPrinter();
        }
    }
}
