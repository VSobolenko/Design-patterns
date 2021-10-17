using Design_patterns.Adapters;
using Design_patterns.DigitalClock;
using Design_patterns.PointerClock;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointerClock casio = new CasioClock();
            ClockInfoPrinter.PrintClockInfo(casio);

            IPointerClock timex = new TimexClock();
            ClockInfoPrinter.PrintClockInfo(timex);

            IDigitalClock china = new ChinaClock();
            PointerClockAdapter chinaAdapter = new PointerClockAdapter(china);
            ClockInfoPrinter.PrintClockInfo(chinaAdapter);

            IDigitalClock tissot = new TissotClock();
            PointerClockAdapter tissotAdapter = new PointerClockAdapter(tissot);
            ClockInfoPrinter.PrintClockInfo(tissotAdapter);
        }
    }
}
