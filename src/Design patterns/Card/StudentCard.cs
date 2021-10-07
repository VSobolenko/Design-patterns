namespace Design_patterns.Card
{
    class StudentCard : CardBase
    {
        public StudentCard()
        {
            Description = "Student card";
        }

        public override string GetModifiers()
        {
            return "RFID tag";
        }
    }
}
