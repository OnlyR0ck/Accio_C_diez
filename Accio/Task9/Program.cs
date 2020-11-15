using System;
using HelperLibrary;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegates = new Menu.MenuDelegate[] { };
            Menu.StartMenu(delegates);
        }

        static void Game()
        {

        }

        static People Start(int n)
        {
            People* people = new People[n];
            return people[n];
        }
    }
}
