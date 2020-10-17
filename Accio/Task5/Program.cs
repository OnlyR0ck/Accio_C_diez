using System;
using HelperLibrary;

namespace Task5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Change array size if you want to add a function.

            var delegates = new Menu.MenuDelegate[2];

            //Explicitly initialize your function in an array.

            delegates[0] = Library;
            delegates[1]= Using;
            Menu.StartMenu(delegates);
        }

        private static void Library()
        {
            Console.WriteLine("Hi, Do you like the menu?");
        }
        private static void Using()
        {
            int areapp;
            using (Building house = new Building { Floors = 2, Area = 2500, Occupents = 4 })
            {
                areapp = house.AreaPerson();
                Console.WriteLine($"The house has:\n {house.Floors} floors\n {house.Occupents} occupants {house.Area} square feet of total area and {areapp} for one person");

            }
            Console.WriteLine("The End :D");
        }
    }
}