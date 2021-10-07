namespace Design_patterns.Card
{
    class BankCard : CardBase
    {
        public BankCard()
        {
            Description = "Bank card";
        }

        public override string GetModifiers()
        {
            return "Modern RFID tag";
        }
    }
}
