using System;

namespace Design_patterns.DigitalClock
{
    class TissotClock : IDigitalClock
    {
        public string Name => "Tissot clock";

        public string GetDigitalHours()
        {
            return "Show digital hours";
        }

        public string GetDigitalMinutes()
        {
            return "Show digital minutes";
        }

        public string GetDigitalSeconds()
        {
            return "Show digital seconds";
        }
    }
}
