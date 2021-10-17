using System;
using Design_patterns.Buttons;

namespace Design_patterns.Commands
{
    class NumberCommand : ICommand
    {
        public bool CanModify => false;

        private readonly Number _number;

        public NumberCommand(Number number)
        {
            _number = number;
        }

        public void Execute()
        {
            Console.WriteLine(_number.GetNubmer());
        }

        public override string ToString()
        {
            return "Press " + _number.GetNubmer();
        }
    }
}
