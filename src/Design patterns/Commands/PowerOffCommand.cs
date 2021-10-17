using Design_patterns.Buttons;

namespace Design_patterns.Commands
{
    class PowerOffCommand : ICommand
    {
        public bool CanModify => true;

        private readonly PowerOff _powerOff;

        public PowerOffCommand(PowerOff powerOff)
        {
            _powerOff = powerOff;
        }

        public void Execute()
        {
            _powerOff.Press();
        }

        public override string ToString()
        {
            return "Disable calculator";
        }
    }
}
