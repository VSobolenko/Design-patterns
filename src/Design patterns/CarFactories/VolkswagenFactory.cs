using Design_patterns.Cars;
using Design_patterns.Cars.Types;
using Design_patterns.ComponentFactories;

namespace Design_patterns.CarFactories
{
    class VolkswagenFactory : CarFactory
    {
        protected override Car CreateCar(CarType type)
        {
            Manufacturer manufacturer = Manufacturer.Volkswagen;

            ICompositionFactory factory = new HighQualityFactory();

            switch (type)
            {
                case CarType.Coupe:
                    return new Coupe(factory, manufacturer);
                case CarType.Hatchback:
                    return new Hatchback(factory, manufacturer);
                case CarType.Micro:
                    return new Micro(factory, manufacturer);
                case CarType.Minivan:
                    return new Minivan(factory, manufacturer);
                case CarType.Pickup:
                    return new Pickup(factory, manufacturer);
                case CarType.Sedan:
                    return new Sedan(factory, manufacturer);
                case CarType.Truck:
                    return new Truck(factory, manufacturer);
                default:
                    break;
            }
            return null;
        }
    }
}
