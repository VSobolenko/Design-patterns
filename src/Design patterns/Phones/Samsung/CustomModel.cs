using System;

namespace Design_patterns.Phones.Samsung
{
    class CustomModel : Phone
    {
        public CustomModel(string model)
        {
            Manufacturer = Manufacturers.Samsung;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} {Model}");
        }
    }
}
