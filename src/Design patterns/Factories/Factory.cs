using Design_patterns.Phones;

namespace Design_patterns.Factories
{
    public abstract class Factory
    {
        public Phone GetPhone(string model, string type = "")
        {
            Phone phone = CreatePhone(model, type);
            phone.Configure();

            return phone;
        }

        protected abstract Phone CreatePhone(string model, string type = "");
    }
}
