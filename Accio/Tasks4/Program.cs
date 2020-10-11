using System;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Threading.Channels;

namespace Tasks4
{
    class Program
    {
        static void Main(string[] args)
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
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }
        }
    }

    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
