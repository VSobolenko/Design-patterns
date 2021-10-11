using System;

namespace Design_patterns.Phones.Samsung
{
    class Galaxy : Phone
    {
        public Galaxy(string model)
        {
            Manufacturer = Manufacturers.Samsung;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Galaxy {Model}");
        }
    }
}
