using System;

namespace Design_patterns.Disk
{
    class ColorPrint : IDisk
    {
        public void PrintDisk()
        {
            Console.WriteLine("Print to disk in different colors");
        }
    }
}
