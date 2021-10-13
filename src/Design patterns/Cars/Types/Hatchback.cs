using Design_patterns.ComponentFactories;

namespace Design_patterns.Cars.Types
{
    class Hatchback : Car
    {
        private readonly ICompositionFactory _factory;

        public Hatchback(ICompositionFactory compositionFactory, Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
            CarType = CarType.Hatchback;

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
