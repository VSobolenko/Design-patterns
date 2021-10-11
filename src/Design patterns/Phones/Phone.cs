namespace Design_patterns.Phones
{
    public abstract class Phone
    {
        protected Manufacturers Manufacturer;
        protected string Model;

        public abstract void Configure();
    }
}
