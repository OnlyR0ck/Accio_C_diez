using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Sphere : IDisposable
    {
        public void Draw(ulong r)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var r_in = r - 0.4;
            var r_out = r + 0.4;
            var minR = (int)r;

            for (var y = (int)r; y >= -minR; --y)
            {
                for (var x = (double)-minR; x < r_out; x += 0.5)
                {
                    var value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}
