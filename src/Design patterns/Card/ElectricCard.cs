namespace Design_patterns.Card
{
    class ElectricCard : CardBase
    {
        public ElectricCard()
        {
            Description = "Universal electric card";
        }

        public override string GetModifiers()
        {
            return "Improved RFID tag";
        }
    }
}
