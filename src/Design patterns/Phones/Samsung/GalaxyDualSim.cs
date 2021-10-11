using System;

namespace Design_patterns.Phones.Samsung
{
    class GalaxyDualSim : Phone
    {
        public GalaxyDualSim(string model)
        {
            Manufacturer = Manufacturers.Samsung;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Galaxy Dual SIM {Model}");
        }
    }
}
