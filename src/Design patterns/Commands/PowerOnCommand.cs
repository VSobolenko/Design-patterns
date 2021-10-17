using Design_patterns.Buttons;

namespace Design_patterns.Commands
{
    class PowerOnCommand : ICommand
    {
        public bool CanModify => true;

        private readonly PowerOn _powerOn;

        public PowerOnCommand(PowerOn powerOn)
        {
            _powerOn = powerOn;
        }

        public void Execute()
        {
            _powerOn.Press();
        }

        public override string ToString()
        {
            return "Enable calculator";
        }
    }
}
