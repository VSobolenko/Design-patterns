using System;
using Design_patterns.PointerClock;

namespace Design_patterns
{
    class ClockInfoPrinter
    {
        public static void PrintClockInfo(IPointerClock clock)
        {
            Console.WriteLine($"\nClock \"{clock.Name}\" show time");
            Console.WriteLine($"Hours: {clock.GetAngleHours()}");
            Console.WriteLine($"Minutes: {clock.GetAngleMinutes()}");
            Console.WriteLine($"Seconds: {clock.GetAngleSeconds()}");
        }
    }
}
