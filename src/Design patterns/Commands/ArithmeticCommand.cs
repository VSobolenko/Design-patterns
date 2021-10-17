using System;
using Design_patterns.Buttons;

namespace Design_patterns.Commands
{
    class ArithmeticCommand : ICommand
    {
        public bool CanModify => false;

        private readonly Arithmetic _arithmetic;

        public ArithmeticCommand(Arithmetic arithmetic)
        {
            _arithmetic = arithmetic;
        }

        public void Execute()
        {
            Console.WriteLine(_arithmetic.GetSign());
        }

        public override string ToString()
        {
            return "Press " + _arithmetic.GetSign();
        }
    }
}
