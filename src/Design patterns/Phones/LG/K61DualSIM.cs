using System;

namespace Design_patterns.Phones.LG
{
    class K61DualSIM : Phone
    {
        public K61DualSIM(string model)
        {
            Manufacturer = Manufacturers.LG;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} K61DualSIM {Model}");
        }
    }
}
