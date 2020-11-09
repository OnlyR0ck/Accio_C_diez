using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Cube : IDisposable
    {
        public void Draw(uint width, uint lenght)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (var i = 0; i < lenght; i++)
            {
                for (var j = 0; j < width; j++) Console.Write("0 ");
                Console.WriteLine();
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}
