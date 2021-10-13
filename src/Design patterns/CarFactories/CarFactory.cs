using Design_patterns.Cars;

namespace Design_patterns.CarFactories
{
    abstract class CarFactory
    {
        public Car GetCar(CarType type)
        {
            Car car = CreateCar(type);
            car.Configure();

            return car;
        }
        protected abstract Car CreateCar(CarType type);
    }
}
