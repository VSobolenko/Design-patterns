using System;

namespace Design_patterns.Phones.LG
{
    class K61 : Phone
    {
        public K61(string model)
        {
            Manufacturer = Manufacturers.LG;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} K61 {Model}");
        }
    }
}
