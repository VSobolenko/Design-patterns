using Design_patterns.Card;

namespace Design_patterns.Decorators
{
    class InsurancePolicyFunction : FunctionsDecoratorBase
    {
        public InsurancePolicyFunction(CardBase card) : base(card)
        {
            Card = card;
        }

        public override string GetModifiers()
        {
            return Card.GetModifiers() + " + insurance policy";
        }
    }
}
