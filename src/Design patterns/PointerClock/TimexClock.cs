using System;

namespace Design_patterns.PointerClock
{
    class TimexClock : IPointerClock
    {
        public string Name => "Timex clock";

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
