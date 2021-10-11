using System;

namespace Design_patterns.Phones
{
    class Velvet : Phone
    {
        public Velvet(string model)
        {
            Manufacturer = Manufacturers.LG;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Velvet {Model}");
        }
    }
}
