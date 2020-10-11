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

          
        }

        private static void SecondTask()
        {
            while (true)
            {
                Console.WriteLine("Enter 2 characters from which we will draw the flag");
                var sumbol = Console.ReadLine();
                if (sumbol != "  " && sumbol.Length != 2) Console.WriteLine("Please try again\n");
                else
                {
                    char[,] flag = new char[6, 15];
                    for (int i = 0; i < flag.GetLength(0); i++)
                    {
                        for (int j = 0; j < flag.GetLength(1); j++)
                        {
                            if (i != 2 && i != 3) flag[i, j] = Convert.ToChar(sumbol.Substring(0, 1));
                            else flag[i, j] = Convert.ToChar(sumbol.Substring(1));
                        }
                    }
                    for (int i = 0; i < flag.GetLength(0); i++)
                    {
                        for (int j = 0; j < flag.GetLength(1); j++) Console.Write(flag[i, j]);
                        Console.Write("\n");
                    }
                    break;
                }
            }

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
                      SecondTask();
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
