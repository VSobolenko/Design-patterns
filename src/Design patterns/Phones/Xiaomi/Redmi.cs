using System;

namespace Design_patterns.Phones.Xiaomi
{
    class Redmi : Phone
    {
        public Redmi(string model)
        {
            Manufacturer = Manufacturers.Xiaomi;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Redmi {Model}");
        }
    }
}
