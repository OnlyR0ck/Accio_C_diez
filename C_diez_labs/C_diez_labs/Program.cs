using System;

namespace C_diez_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int code = 1;
            while (Convert.ToBoolean(code))
            {
                Console.WriteLine("1 - Factorial\n2 - Fibonnaci\n3 - Create shape\n4 - Quess the number game\n0 - exit");
                Console.Write("Your choice : ");
                int.TryParse(Console.ReadLine(), out code);
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
                Console.Clear();
            }
        }

        static void Factorial()
        {
            Console.Write("Enter a number : ");
            int num , temp;
            int.TryParse(Console.ReadLine(), out num);
            temp = num;
            int result = 1;
            while (Convert.ToBoolean(num))
            {
                result *= num;
                num--;
            }

            Console.WriteLine(String.Concat("The factorial of ", temp, " is : ", result));

            Console.Read();
        }

        //
        static void Fibonnaci()
        {
            int now = 1, temp = 0, fake = 0, n;
            Console.Write("How many numbers to deduce from the fibbonacci sequence : ");
            int.TryParse(Console.ReadLine(), out n);
            Console.Write("Fibbonaci sequence : ");
            for (int i = 0; i < n; i++)
            {
                fake = now;
                now += temp;
                Console.Write(String.Concat(" ", now));
                temp = fake;
            }

            Console.ReadLine();
        }

        static void CreateShape()
        {
            int kode = 1;

            Console.WriteLine("Draw a circle/ellipse. Enter: 1 \nDraw polygon. Enter: 2 ");
            kode = Convert.ToInt16(Console.ReadLine());
            if (kode == 1)
            {
                Console.WriteLine("Эллипс: 1\nКруг: 2\n");
                kode = Convert.ToInt16(Console.ReadLine());
                if (kode == 1)
                {
                    Console.WriteLine("Представте что здесь нарисован элллипс\n");
                }
                else
                {
                    Console.WriteLine("Представте что здесь нарисован круг\n");
                }

            }
            else
            {
                Console.WriteLine("Введите количесвто сторон многоугольника\n");
                int n = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"Представте что здесь нарисован многоугольик с {n} сторонами\n");
            }

            Console.ReadLine();
        }

        static void QuessTheNumber()
        {
            Console.Clear();
            Console.WriteLine("YOU WANNA PLAY - LET'S PLAY. BY ALEX NEVSKIY");
            Console.WriteLine("\n\nGuess the number from 0 to 1000");
            int upper = 1000, lower = 0, middlle;
            bool flag = true;
            while (lower <= upper)
            {
                middlle = (upper + lower) / 2;
                Console.WriteLine(String.Concat("Is the ", middlle, " your number? Type Y or N"));
                switch (Console.ReadLine().ToLower())
                {
                    case "y":
                        Console.WriteLine("Yeah, I'm won !!!");
                        flag = false;
                        break;
                    case "n":
                        Console.WriteLine("Ok, just another question.");
                        break;
                    default:
                        Console.WriteLine("Are you kidding me? So, let's start again.");
                        continue;
                }

                if (!flag) break;
                Console.WriteLine(
                    String.Concat("\nTell me, Is your num bigger or less than ", middlle, " Type B or L."));
                switch (Console.ReadLine().ToLower())
                {
                    case "b":
                        lower = middlle - 1;
                        break;
                    case "l":
                        upper = middlle + 1;
                        break;
                    default:
                        Console.WriteLine("Are you kidding me? So, let's start again.");
                        continue;
                }
            }
        }
    }
}
    

    