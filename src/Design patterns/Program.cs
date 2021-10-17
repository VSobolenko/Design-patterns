using Design_patterns.ComputerComponents;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var apple = new Computer(new Power(), new OperatingSystemComputer("Windows"), new Programms());

            apple.OpenProgramm("editor");

            apple.EnableComputer();
            apple.OpenProgramm("editor");
            apple.DisableComputer();

            apple.DisableComputer();
        }
    }
}
