using Design_patterns.Disk;
using Design_patterns.FDM;
using Design_patterns.Paper;
using Design_patterns.SLA;

namespace Design_patterns.Printers
{
    abstract class PrinterBase
    {
        public abstract string Model { get; protected set; }

        protected IDisk diskBehaviour;
        protected IPaper paperBehaviour;
        protected IFdm fdmBehaviour;
        protected ISla slaBehaviour;

        public PrinterBase()
        {
            diskBehaviour = new Disk.NotPrint();
            paperBehaviour = new Paper.NotPrint();
            fdmBehaviour = new FDM.NotPrint();
            slaBehaviour = new SLA.NotPrint();
        }

        public void PrintDisk()
        {
            diskBehaviour.PrintDisk();
        }

        public void PrintPaper()
        {
            paperBehaviour.PrintPaper();
        }

        public void PrintFDM()
        {
            fdmBehaviour.PrintFDM();
        }

        public void PrintSLA()
        {
            slaBehaviour.PrintSLA();
        }
    }
}
