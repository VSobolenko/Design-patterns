using Design_patterns.ComponentFactories;

namespace Design_patterns.Cars.Types
{
    class Truck : Car
    {
        private readonly ICompositionFactory _factory;

        public Truck(ICompositionFactory compositionFactory, Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
            CarType = CarType.Truck;

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
