using Design_patterns.ComponentFactories;

namespace Design_patterns.Cars.Types
{
    class Micro : Car
    {
        private readonly ICompositionFactory _factory;

        public Micro(ICompositionFactory compositionFactory, Manufacturer manufacturer)
        {
            Manufacturer = manufacturer;
            CarType = CarType.Micro;

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
