using Design_patterns.Factories;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenovo = new LenovoFactory();
            lenovo.GetPhone("A7000");
            lenovo.GetPhone("S304", "Legion");
            lenovo.GetPhone("S60", "Vibe");

            var lg = new LGFactory();
            lg.GetPhone("NDzk31", "Velvet");
            lg.GetPhone("Z30", "K61DualSim");
            lg.GetPhone("Ty130", "Wing");

            var samsung = new SamsungFactory();
            samsung.GetPhone("Prime", "Grand");
            samsung.GetPhone("S9", "Galaxy");
            samsung.GetPhone("Z Flip", "Galaxy.Fold");

            var xiaomi = new XiaomiFactory();
            xiaomi.GetPhone("7", "RedmiNote");
            xiaomi.GetPhone("9T", "Redmi");
            xiaomi.GetPhone("11 Ultra", "Mi");
        }
    }
}
