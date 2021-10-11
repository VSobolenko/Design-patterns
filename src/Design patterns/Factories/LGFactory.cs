using Design_patterns.Phones;
using Design_patterns.Phones.LG;

namespace Design_patterns.Factories
{
    class LGFactory : Factory
    {
        protected override Phone CreatePhone(string model, string type = "")
        {
            switch (type)
            {
                case "K61":
                    return new K61(model);
                case "K61DualSIM":
                    return new K61DualSIM(model);
                case "Velvet":
                    return new Velvet(model);
                case "Wing":
                    return new Wing(model);
                default:
                    return new CustomModel(model);
            }
        }
    }
}
