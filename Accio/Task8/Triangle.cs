using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Triangle : IDisposable
    {
        public void Draw(uint first)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (var i = 0; i < first; i++)
            {
                for (var j = 0; j < i; j++) Console.Write('0');
                Console.WriteLine();
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}
