using System;

namespace Design_patterns.PointerClock
{
    class CasioClock : IPointerClock
    {
        public string Name => "Casio clock";

        public string GetAngleHours()
        {
            return "Show pointer hours";
        }

        public string GetAngleMinutes()
        {
            return "Show pointer minutes";
        }

        public string GetAngleSeconds()
        {
            return "Show pointer seconds";
        }
    }
}
