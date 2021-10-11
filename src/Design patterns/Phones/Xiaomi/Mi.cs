using System;

namespace Design_patterns.Phones.Xiaomi
{
    class Mi : Phone
    {
        public Mi(string model)
        {
            Manufacturer = Manufacturers.Xiaomi;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Mi {Model}");
        }
    }
}
