namespace Design_patterns.PointerClock
{
    interface IPointerClock
    {
        string Name { get; }

        string GetAngleHours();
        string GetAngleMinutes();
        string GetAngleSeconds();
    }
}
