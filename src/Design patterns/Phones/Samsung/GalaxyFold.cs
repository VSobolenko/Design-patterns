using System;

namespace Design_patterns.Phones.Samsung
{
    class GalaxyFold : Phone
    {
        public GalaxyFold(string model)
        {
            Manufacturer = Manufacturers.Samsung;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Galaxy Fold {Model}");
        }
    }
}
