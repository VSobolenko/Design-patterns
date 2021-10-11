using Design_patterns.Phones;
using Design_patterns.Phones.Samsung;

namespace Design_patterns.Factories
{
    class SamsungFactory : Factory
    {
        protected override Phone CreatePhone(string model, string type = "")
        {
            switch (type)
            {
                case "Galaxy":
                    return new Galaxy(model);
                case "GalaxyDualSim":
                    return new GalaxyDualSim(model);
                case "GalaxyFold":
                    return new GalaxyFold(model);
                case "GalaxyGrand":
                    return new GalaxyGrand(model);
                default:
                    return new CustomModel(model);
            }
        }
    }
}
