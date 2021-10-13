using Design_patterns.CarsComponents;
using Design_patterns.CarsComponents.Bodys;
using Design_patterns.CarsComponents.ChassisType;
using Design_patterns.CarsComponents.Engines;

namespace Design_patterns.ComponentFactories
{
    class HighQualityFactory : ICompositionFactory
    {
        public Body GetBody()
        {
            return new SteelBody();
        }

        public Chassis GetChassis()
        {
            return new FortifiedChassis();
        }

        public Engine GetEngine()
        {
            return new DoubleEngine();
        }
    }
}
