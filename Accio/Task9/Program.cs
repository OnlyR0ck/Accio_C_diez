using System;
using System.Collections.Generic;
using HelperLibrary;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegates = new Menu.MenuDelegate[] {Game };
            Menu.StartMenu(delegates);
        }

        static void Game()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            var people = Start(n);
            Console.WriteLine();
            people[i].Many();
            Console.WriteLine();
            Console.WriteLine("I am the first");
            Console.Write("Next");
            people[i].PrevNext(people[i + 1].Liars);
            for (i = 1; i < n-1; i++)
            {
                Console.WriteLine($"{i} Man");
                Console.Write("Pev");
                people[i].PrevNext(people[i - 1].Liars);
                Console.Write("Next");
                people[i].PrevNext(people[i + 1].Liars);
            }
            Console.WriteLine("I am the last");
            Console.Write("Pev");
            people[i].PrevNext(people[i - 1].Liars);
            people[i].Clear();
        }

        static List<dynamic> Start(int n)
        {
            List<dynamic> people = new List<dynamic>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                if (rnd.Next(2) == 0)
                {
                    Console.WriteLine("Лгун");
                    people.Add(new Liars() { Liars = true });
                }
                else
                {
                    Console.WriteLine("НеЛгун");
                    people.Add(new Honest() { Liars = false });
                }
            }
            return people;
        }
    }
}
