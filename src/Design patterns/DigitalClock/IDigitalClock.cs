namespace Design_patterns.DigitalClock
{
    interface IDigitalClock
    {
        string Name { get; }

        string GetDigitalHours();
        string GetDigitalMinutes();
        string GetDigitalSeconds();
    }
}
