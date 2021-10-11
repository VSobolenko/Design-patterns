using System;

namespace Design_patterns.Phones.LG
{
    class CustomModel : Phone
    {
        public CustomModel(string model)
        {
            Manufacturer = Manufacturers.LG;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} {Model}");
        }
    }
}
