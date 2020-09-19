using System;

namespace C_diez_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int code = 1;
            Console.WriteLine("1 - Factorial\n2 - Fibonnaci\n3 - Create shape\n4 - Quess the number game\n0 - exit");
            while (Convert.ToBoolean(code))
            {
                code = Console.Read();
                switch (code)
                {
                    case 1:
                        Factorial();
                        break;
                    case 2:
                        Fibonnaci();
                        break;
                    case 3:
                        CreateShape();
                        break;
                    case 4:
                        QuessTheNumber();
                        break;
                    default:
                        code = 0;
                        break;

                }
            }
        }

        static void Factorial()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.Read());
            int result = 1;
            while (Convert.ToBoolean(num))
            {
                result *= num;
                num--;
            }

            Console.WriteLine(String.Concat("The factorial of ", num, " is : ", result));
        }

        static void Fibonnaci()
        {

        }

        static void CreateShape()
        {

        }

        static void QuessTheNumber()
        {

        }
    }
}
