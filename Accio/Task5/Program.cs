using System;
using HelperLibrary;

namespace Task5
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //Change array size if you want to add a function.

            Menu.MenuDelegate[] delegates = new Menu.MenuDelegate[1];

            //Explicitly initialize your function in an array.

            delegates[0] = Library;
            HelperLibrary.Menu.StartMenu(delegates);
        }

        static void Library()
        {
            Console.WriteLine("Hi, Do you like the menu?");
        }

    }
}


