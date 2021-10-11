using System;

namespace Design_patterns.Phones.Lenovo
{
    class Vibe : Phone
    {
        public Vibe(string model)
        {
            Manufacturer = Manufacturers.Lenovo;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Vibe {Model}");
        }
    }
}
