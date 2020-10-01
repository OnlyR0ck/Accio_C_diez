using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void menu()
        {
            int code;

            while (true)
            {
                Console.WriteLine("1 - Counter.\n2 - Generic.\n3 - Ducks.\n0 - Exit.");
                Console.Write("Answer: ");
                int.TryParse(Console.ReadLine(), out code);
                switch (code)
                {
                    case 1:
                        first();
                        break;
                    case 2:
                        second();
                        break;
                    case 3:
                        third();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }

            }
        }
        static void first()
        {

        }

        static void second()
        {

        }

        static void third()
        {

        }
    }
}
