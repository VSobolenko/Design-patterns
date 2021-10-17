using Design_patterns.Buttons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Commands
{
    class TrigonometricCommand : ICommand
    {
        public bool CanModify => throw new NotImplementedException();

        private readonly Trigonometric _trigonometric;

        public TrigonometricCommand(Trigonometric trigonometric)
        {
            _trigonometric = trigonometric;
        }

        public void Execute()
        {
            Console.WriteLine(_trigonometric.GetFunctionAngle());
        }

        public override string ToString()
        {
            return "Press " + _trigonometric.GetFunctionAngle() + "(..)";
        }
    }
}
