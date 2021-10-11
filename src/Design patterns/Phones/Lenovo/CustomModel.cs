using System;

namespace Design_patterns.Phones.Lenovo
{
    class CustomModel : Phone
    {
        public CustomModel(string model)
        {
            Manufacturer = Manufacturers.Lenovo;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} {Model}");
        }
    }
}
