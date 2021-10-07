using Design_patterns.Card;

namespace Design_patterns.Decorators
{
    class AuthenticationFunction : FunctionsDecoratorBase
    {
        public AuthenticationFunction(CardBase card) : base(card)
        {
            Card = card;
        }

        public override string GetModifiers()
        {
            return Card.GetModifiers() + " + authentication";
        }
    }
}
