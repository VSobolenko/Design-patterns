using System.Collections.Generic;
using System.Text;
using Design_patterns.Commands;

namespace Design_patterns
{
    class Keyboard
    {
        private readonly Dictionary<int, ICommand> _buttons;

        public Keyboard()
        {
            _buttons = new Dictionary<int, ICommand>();
        }

        public void SetCommandForButton(int buttonId, ICommand command)
        {
            _buttons[buttonId] = command;
        }

        public void PressOnButton(int buttonId)
        {
            if (_buttons.ContainsKey(buttonId))
                _buttons[buttonId].Execute();
        }

        public void ChangeButtonCommand(int buttonId, ICommand newCommand)
        {
            if (_buttons.ContainsKey(buttonId))
                if (_buttons[buttonId].CanModify)
                    _buttons[buttonId] = newCommand;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var button in _buttons)
            {
                sb.AppendFormat($"{button.Key} - {button.Value.ToString()}\n");
            }
            return sb.ToString();
        }
    }
}
