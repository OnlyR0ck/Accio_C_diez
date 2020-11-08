using System;
using System.Collections.Generic;
using HelperLibrary;
using static Task7.MyThread;
using static Task7.Rainbow;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegates = new Menu.MenuDelegate[] {Competition, ShowRainbow };
            Menu.StartMenu(delegates);
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
}
