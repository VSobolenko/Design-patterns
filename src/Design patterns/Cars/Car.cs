using Design_patterns.CarsComponents;

namespace Design_patterns.Cars
{
    abstract class Car
    {
        protected CarType CarType;
        protected Manufacturer Manufacturer;

        protected Body Body { get; set; }
        protected Chassis Chassis { get; set; }
        protected Engine Engine { get; set; }

        public abstract void Configure();

        public override string ToString()
        {
            return $"Car: {CarType}" +
                $"\n   Manufacturer: {Manufacturer}" +
                $"\n   Mode:" +
                $"\n\tBody: {Body.GetMetal()}" +
                $"\n\tChassis: {Chassis.GetQuality()}" +
                $"\n\tEngine: {Engine.GetWorkingMode()}";
        }
    }
}
