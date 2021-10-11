using System;

namespace Design_patterns.Phones.Samsung
{
    class GalaxyGrand : Phone
    {
        public GalaxyGrand(string model)
        {
            Manufacturer = Manufacturers.Samsung;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Galaxy Grand {Model}");
        }
    }
}
