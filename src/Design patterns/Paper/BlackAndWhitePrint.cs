using System;

namespace Design_patterns.Paper
{
    class BlackAndWhitePrint : IPaper
    {
        public void PrintPaper()
        {
            Console.WriteLine("Print to paper in black and white colors");
        }
    }
}
