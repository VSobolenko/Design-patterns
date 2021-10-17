namespace Design_patterns.Buttons
{
    class Arithmetic
    {
        private readonly string _sign;

        public Arithmetic(string sign)
        {
            _sign = sign;
        }

        public string GetSign()
        {
            return _sign;
        }


    }
}
