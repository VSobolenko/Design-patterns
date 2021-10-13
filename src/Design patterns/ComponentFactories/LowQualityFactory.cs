using Design_patterns.CarsComponents;
using Design_patterns.CarsComponents.Bodys;
using Design_patterns.CarsComponents.ChassisType;
using Design_patterns.CarsComponents.Engines;

namespace Design_patterns.ComponentFactories
{
    class LowQualityFactory : ICompositionFactory
    {
        public Body GetBody()
        {
            return new CopperBody();
        }

        public Chassis GetChassis()
        {
            return new WeakChassis();
        }

        public Engine GetEngine()
        {
            return new InlineEngine();
        }
    }
}
