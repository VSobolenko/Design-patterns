using System;
using Design_patterns.Commands;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyboard = new Keyboard();
            SetDefaultKeyboard(keyboard);

            string userInput;

            do
            {
                Console.WriteLine("Buttons:");
                Console.WriteLine(keyboard.ToString());

                Console.Write("Choose button: ");
                var input = Console.ReadLine();
                int.TryParse(input, out int buttonId);

                keyboard.PressOnButton(buttonId);

                Console.Write("Do you want to continue? (y/n): ");
                userInput = Console.ReadLine();
            } while (userInput == "y");
        }

        static void SetDefaultKeyboard(Keyboard keyboard)
        {
            keyboard.SetCommandForButton(0, new ArithmeticCommand(new Buttons.Arithmetic("+")));
            keyboard.SetCommandForButton(1, new ArithmeticCommand(new Buttons.Arithmetic("-")));
            keyboard.SetCommandForButton(2, new NumberCommand(new Buttons.Number(1)));
            keyboard.SetCommandForButton(3, new NumberCommand(new Buttons.Number(2)));
            keyboard.SetCommandForButton(4, new NumberCommand(new Buttons.Number(3)));
            keyboard.SetCommandForButton(5, new PowerOnCommand(new Buttons.PowerOn()));
            keyboard.SetCommandForButton(6, new PowerOffCommand(new Buttons.PowerOff()));
            keyboard.SetCommandForButton(7, new TrigonometricCommand(new Buttons.Trigonometric("sin")));
            keyboard.SetCommandForButton(8, new TrigonometricCommand(new Buttons.Trigonometric("cos")));
        }
    }
}
