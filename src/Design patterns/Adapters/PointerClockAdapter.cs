using Design_patterns.DigitalClock;
using Design_patterns.PointerClock;

namespace Design_patterns.Adapters
{
    class PointerClockAdapter : IPointerClock
    {
        private readonly IDigitalClock _digitalClock;

        public PointerClockAdapter(IDigitalClock digitalClock)
        {
            _digitalClock = digitalClock;
        }

        public string Name => _digitalClock.Name;

        public string GetAngleHours()
        {
            return _digitalClock.GetDigitalHours();
        }

        public string GetAngleMinutes()
        {
            return _digitalClock.GetDigitalMinutes();
        }

        public string GetAngleSeconds()
        {
            return _digitalClock.GetDigitalSeconds();
        }
    }
}
