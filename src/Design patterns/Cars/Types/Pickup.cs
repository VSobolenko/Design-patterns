using Design_patterns.ComponentFactories;

namespace Design_patterns.Cars.Types
{
    class Pickup : Car
    {
        private readonly ICompositionFactory _factory;

        public Pickup(ICompositionFactory compositionFactory, Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
            CarType = CarType.Pickup;

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
