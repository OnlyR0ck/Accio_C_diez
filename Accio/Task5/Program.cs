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
            delegates[2] = Proverochka;
            Menu.StartMenu(delegates);
        }

        private static void Proverochka()
        {
            Drawing();
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
        static void Drawing()
        {
            Console.Clear();
          

            Console.WriteLine("\n1 - Triangle.\n2 - Cube.\n3 - Sphere.");
            var kode = Console.ReadLine();

            switch(Convert.ToInt32(kode))
            {
                case 1:
                    Triangle tr = new Triangle();
                    break;
                case 2:
                    Cube cb = new Cube();
                    break;
                case 3:
                    Sphere sph = new Sphere();
                    break;
            }
        }
         
           
       
        internal abstract class Shape
        {
            public abstract void Draw();
        }
                            
        internal class Triangle : Shape
        {
            public override void Draw()
            {
                for (var i = 0; i < 10; i++)
                {
                    for (var j = 0; j < i; j++) Console.Write('0');
                    Console.WriteLine();
                }
            }
        }

        internal class Cube : Shape
        {
            public override void Draw()
            {
                for (var i = 0; i < 10; i++)
                {
                    for (var j = 0; j < 10; j++) Console.Write("0 ");
                    Console.WriteLine();
                }
            }
        }

        internal class Sphere : Shape
        {
            public override void Draw()
            {
                var r = 7.0;
                var r_in = r - 0.4;
                var r_out = r + 0.4;

                for (var y = r; y >= -r; --y)
                {
                    for (var x = -r; x < r_out; x += 0.5)
                    {
                        var value = x * x + y * y;
                        if (value >= r_in * r_in && value <= r_out * r_out)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}