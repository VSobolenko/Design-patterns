using Design_patterns.Card;

namespace Design_patterns.Decorators
{
    abstract class FunctionsDecoratorBase : CardBase
    {
        protected CardBase Card { get; set; }

        protected FunctionsDecoratorBase(CardBase card)
        {
            Card = card;
            Description = Card.Description;
        }

        public override string GetModifiers()
        {
            return string.Empty;
        }
    }
}
