using System;

namespace Design_patterns.Phones.Xiaomi
{
    class RedmiNote : Phone
    {
        public RedmiNote(string model)
        {
            Manufacturer = Manufacturers.Xiaomi;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Redmi Note {Model}");
        }
    }
}
