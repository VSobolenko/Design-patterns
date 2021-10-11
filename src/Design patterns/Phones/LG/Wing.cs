using System;

namespace Design_patterns.Phones.LG
{
    class Wing : Phone
    {
        public Wing(string model)
        {
            Manufacturer = Manufacturers.LG;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Wing {Model}");
        }
    }
}
