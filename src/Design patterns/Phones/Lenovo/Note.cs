using System;

namespace Design_patterns.Phones.Lenovo
{
    class Note : Phone
    {
        public Note(string model)
        {
            Manufacturer = Manufacturers.Lenovo;
            Model = model;
        }

        public override void Configure()
        {
            Console.WriteLine($"{Manufacturer} Note {Model}");
        }
    }
}
