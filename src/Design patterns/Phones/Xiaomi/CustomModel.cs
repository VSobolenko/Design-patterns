using System;

namespace Design_patterns.Phones.Xiaomi
{
    class CustomModel : Phone
    {
        public CustomModel(string model)
        {
            Manufacturer = Manufacturers.Xiaomi;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} {Model}");
        }
    }
}
