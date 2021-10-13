using Design_patterns.ComponentFactories;

namespace Design_patterns.Cars.Types
{
    class Coupe : Car
    {
        private readonly ICompositionFactory _factory;

        public Coupe(ICompositionFactory compositionFactory, Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
            CarType = CarType.Coupe;

            _factory = compositionFactory;
        }

        public override void Configure()
        {
            Body = _factory.GetBody();
            Chassis = _factory.GetChassis();
            Engine = _factory.GetEngine();
        }
    }
}
