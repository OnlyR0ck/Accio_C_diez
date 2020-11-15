using System;
using System.Collections.Generic;
using HelperLibrary;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegates = new Menu.MenuDelegate[] {Game, BottlesOfBeer};
            Menu.StartMenu(delegates);
        }

        static void BottlesOfBeer()
        {
            ScriptEngine engine = Python.CreateEngine();
            engine.ExecuteFile("D:\\Git Projects\\Accio_C_diez\\Accio\\Task9\\99bottles.py");
        }

        static void Game()
        {
            Console.WriteLine("How many people do you want to add to the game?");
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
                Console.WriteLine($"{i+1} Man");
                Console.Write("Prev");
                people[i].PrevNext(people[i - 1].Liars);
                Console.Write("Next");
                people[i].PrevNext(people[i + 1].Liars);
            }
            Console.WriteLine("I am the last");
            Console.Write("Prev");
            people[i].PrevNext(people[i - 1].Liars);
            Console.WriteLine("\n\tEnter 1 if Lairs\n\tEnter 2 if not Lairs\n");
            var score = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1} man was ?");
                var c = Convert.ToInt32(Console.ReadLine());
               
                if (c == 1)
                {
                    if (people[i].Liars) score += 1;
                    
                }
                else
                {
                    if (people[i].Liars!=true) score += 1;
                }
            }
            if (score != n)
            {
                Console.WriteLine("OOOoooo shit you are mistaken (");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lox");
                Console.ResetColor();
                for (int j = 0; j < n; j++)
                {
                    
                    if (people[j].Liars)
                    {
                        Console.WriteLine($"{j+1}Liar");
                    }
                    else
                    {
                        Console.WriteLine($"{j+1}Not Liar");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Congratulations, you win !!!!!!");
            }
            people[i-1].Clear();
        }
        
        static List<dynamic> Start(int n)
        {
            List<dynamic> people = new List<dynamic>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                if (rnd.Next(2) == 0)
                {
                   
                    people.Add(new Liars() { Liars = true });
                }
                else
                {
                   
                    people.Add(new Honest() { Liars = false });
                }
            }
            return people;
        }
    }
}
