using System;
using Design_patterns.Card;
using Design_patterns.Decorators;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CardBase universalCard = new ElectricCard();
            CardBase studentCard = new StudentCard();
            CardBase bankCard = new BankCard();

            universalCard = new PassportFunctions(new InsurancePolicyFunction(new BankFunction(new AuthenticationFunction(universalCard))));
            studentCard = new AuthenticationFunction(studentCard);
            bankCard = new BankFunction(new AuthenticationFunction(bankCard));

            PrintCard(universalCard);
            PrintCard(studentCard);
            PrintCard(bankCard);
        }

        static void PrintCard(CardBase card)
        {
            Console.WriteLine($"Card: {card.Description} - Modifiers: {card.GetModifiers()}");
        }
    }
}
