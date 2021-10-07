namespace Design_patterns.Card
{
    abstract class CardBase
    {
        public virtual string Description { get; protected set; }

        public abstract string GetModifiers();
    }
}
