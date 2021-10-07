using Design_patterns.Card;

namespace Design_patterns.Decorators
{
    class PassportFunctions : FunctionsDecoratorBase
    {
        public PassportFunctions(CardBase card) : base(card)
        {
            Card = card;
        }

        public override string GetModifiers()
        {
            return Card.GetModifiers() + " + passport";
        }
    }
}
