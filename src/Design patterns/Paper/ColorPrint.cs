using System;

namespace Design_patterns.Paper
{
    class ColorPrint : IPaper
    {
        public void PrintPaper()
        {
            Console.WriteLine("Print to paper in different colors");
        }
    }
}
