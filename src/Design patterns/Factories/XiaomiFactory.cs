using Design_patterns.Phones;
using Design_patterns.Phones.Xiaomi;

namespace Design_patterns.Factories
{
    class XiaomiFactory : Factory
    {
        protected override Phone CreatePhone(string model, string type = "")
        {
            switch (type)
            {
                case "RedmiNote":
                    return new RedmiNote(model);
                case "Redmi":
                    return new Redmi(model);
                case "Mi":
                    return new Mi(model);
                default:
                    return new CustomModel(model);
            }
        }
    }
}
