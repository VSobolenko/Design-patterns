using Design_patterns.CarFactories;
using Design_patterns.Cars;
using System;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory bmw = new BMWFactory();
            Car coupeBMW = bmw.GetCar(CarType.Coupe);
            Car hatchbackBMW = bmw.GetCar(CarType.Hatchback);

            CarFactory toyota = new ToyotaFactory();
            Car hatchbackToyota = toyota.GetCar(CarType.Hatchback);
            Car minivanToyota = toyota.GetCar(CarType.Minivan);

            CarFactory volkswagen = new VolkswagenFactory();
            Car minivanVolkswagen = volkswagen.GetCar(CarType.Minivan);
            Car pickupVolkswagen = volkswagen.GetCar(CarType.Pickup);

            PrintAbotCars(coupeBMW, hatchbackBMW, hatchbackToyota
                , minivanToyota, minivanVolkswagen, pickupVolkswagen);
        }

        static void PrintAbotCars(params Car[] cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
                Console.WriteLine();
            }
        }
    }
}
