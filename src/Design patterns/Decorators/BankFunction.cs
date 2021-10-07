using Design_patterns.Card;

namespace Design_patterns.Decorators
{
    class BankFunction : FunctionsDecoratorBase
    {
        public BankFunction(CardBase card) : base(card)
        {
            Card = card;
        }

        public override string GetModifiers()
        {
            return Card.GetModifiers() + " + bank function";
        }
    }
}
