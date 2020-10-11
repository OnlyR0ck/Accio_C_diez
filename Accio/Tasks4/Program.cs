using System;

namespace Tasks4
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondTask();
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
        }
    }
}
