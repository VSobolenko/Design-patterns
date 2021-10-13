using Design_patterns.CarsComponents;

namespace Design_patterns.ComponentFactories
{
    interface ICompositionFactory
    {
        Body GetBody();
        Chassis GetChassis();
        Engine GetEngine();
    }
}
