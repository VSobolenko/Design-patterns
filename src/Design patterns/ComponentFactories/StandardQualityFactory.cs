using Design_patterns.CarsComponents;
using Design_patterns.CarsComponents.Bodys;
using Design_patterns.CarsComponents.ChassisType;
using Design_patterns.CarsComponents.Engines;

namespace Design_patterns.ComponentFactories
{
    class StandardQualityFactory : ICompositionFactory
    {
        public Body GetBody()
        {
            return new AluminumBody();
        }

        public Chassis GetChassis()
        {
            return new StandardChassis();
        }

        public Engine GetEngine()
        {
            return new VTypeEngine();
        }
    }
}
