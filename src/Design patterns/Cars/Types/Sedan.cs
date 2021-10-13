using Design_patterns.ComponentFactories;

namespace Design_patterns.Cars.Types
{
    class Sedan : Car
    {
        private readonly ICompositionFactory _factory;

        public Sedan(ICompositionFactory compositionFactory, Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
            CarType = CarType.Sedan;

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
