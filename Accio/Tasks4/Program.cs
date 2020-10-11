using System;

namespace Tasks4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var code = 1;
            while (Convert.ToBoolean(code))
            {
                Console.WriteLine("1 - Draw shapes\n2 - Draw flags\n3 - WTF\n0 - Exit");
                Console.Write("Your choice : ");
                int.TryParse(Console.ReadLine(), out code);
                switch (code)
                {
                    case 1:
                        Drawing();
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.ReadKey(true);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }

                Console.Clear();
            }

            static void Drawing()
            {
                Console.Clear();
                Shape[] shapes = new Shape[4];
                var ShapeNum = 0;
                
                shapes[0] = new Triangle();
                shapes[1] = new Cube();
                shapes[2] = new Sphere();
                GetShape(shapes, out ShapeNum).Draw();
                ShapeNum++;

                Console.WriteLine("\nWhat is this figure?\n1 - Triangle.\n2 - Cube.\n3 - Sphere.");
                int code = 0;
                Console.Write("\nYour choice: ");
                int.TryParse(Console.ReadLine(), out code);
                Console.WriteLine(ShapeNum == code ? "You Win!" : "You lose!");
            }

            static Shape GetShape(Shape[] shapes, out int ShapeNum)
            {
                ShapeNum = new Random().Next(3);
                return shapes[ShapeNum];
            }
        }
    }

    internal abstract class Shape
    {
        public abstract void Draw();
    }

    internal class Triangle : Shape
    {
        public override void Draw()
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < i; j++) Console.Write('0');
                Console.WriteLine();
            }
        }
    }

    internal class Cube : Shape
    {
        public override void Draw()
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 10; j++) Console.Write("0 ");
                Console.WriteLine();
            }
        }
    }

    internal class Sphere : Shape
    {
        public override void Draw()
        {
            var r = 7.0;
            var r_in = r - 0.4;
            var r_out = r + 0.4;

            for (var y = r; y >= -r; --y)
            {
                for (var x = -r; x < r_out; x += 0.5)
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
    }
}