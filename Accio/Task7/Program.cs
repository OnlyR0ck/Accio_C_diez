using System;

using System.Collections.Generic;

using HelperLibrary;

using static Task7.MyThread;
using static Task7.Rainbow;
namespace Task7
{
    class Program
    {
        static void Main()
        {
            var delegates = new Menu.MenuDelegate[] {Competition, ShowRainbow, SecondTask };
            Menu.StartMenu(delegates);
        }

        static void SecondTask()
        {
            Console.WriteLine("Enter country");
            var country = Console.ReadLine();
            CountryRainbow r = new CountryRainbow(country);
            foreach (string s in r)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(s[0]);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(s[1]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(s[2]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(s[3]);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(s[4]);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(s[5]);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(s[6]);
            }
        }

        static void Competition()
        {
            MyThread mt = new MyThread("97", 60);
            MyThread mt2 = new MyThread("3", 60);
        }

        static void ShowRainbow()
        {
            Rainbow rbow = new Rainbow();
            foreach (var color in rbow)
            {
                Console.WriteLine(color);
            }
        }
    }

    class CountryRainbow 
    {
  
        
        private readonly string _count;
        public CountryRainbow(string country)
        {
            _count = country;
        }
        public IEnumerator<string> GetEnumerator()
        {
         string[] rain = { "rainbow", "rainbow", "rainbow", "rainbow", "rainbow" };
            if (_count != "Russia")
            {
                Console.WriteLine("Rainbow inaf");
            }
            else
            {
                    yield return rain[0];
                    yield return rain[1];
                    yield return rain[2];
                    yield return rain[3];
                    yield return rain[4];
            }
        }
    }

    

    
}
