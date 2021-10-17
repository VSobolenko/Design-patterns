namespace Design_patterns.Buttons
{
    class Trigonometric
    {
        private readonly string _functionAngle;

        public Trigonometric(string functionAngle)
        {
            _functionAngle = functionAngle;
        }

        public string GetFunctionAngle()
        {
            return _functionAngle;
        }
    }
}
