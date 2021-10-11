using Design_patterns.Phones;
using Design_patterns.Phones.Lenovo;

namespace Design_patterns.Factories
{
    class LenovoFactory : Factory
    {
        protected override Phone CreatePhone(string model, string type = "")
        {
            switch (type)
            {
                case "Legion":
                    return new Legion(model);
                case "Note":
                    return new Note(model);
                case "Vibe":
                    return new Vibe(model);
                default:
                    return new CustomModel(model);
            }
        }
    }
}
