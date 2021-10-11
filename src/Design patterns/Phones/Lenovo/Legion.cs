using System;

namespace Design_patterns.Phones.Lenovo
{
    class Legion : Phone
    {
        public Legion(string model)
        {
            Manufacturer = Manufacturers.Lenovo;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Legion {Model}");
        }
    }
}
