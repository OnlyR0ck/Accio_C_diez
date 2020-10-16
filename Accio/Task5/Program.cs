using System;
using HelperLibrary;

namespace Task5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Change array size if you want to add a function.

            var delegates = new Menu.MenuDelegate[1];

            //Explicitly initialize your function in an array.

            delegates[0] = Library;
            Menu.StartMenu(delegates);
        }

        private static void Library()
        {
            Console.WriteLine("Hi, Do you like the menu?");
        }
    }
}