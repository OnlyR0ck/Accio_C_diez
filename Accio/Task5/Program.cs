using System;
using System.IO;
using System.Runtime.CompilerServices;
using HelperLibrary;

namespace Task5
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            //Change array size if you want to add a function.

            var delegates = new Menu.MenuDelegate[3];

            //Explicitly initialize your function in an array.

            delegates[0] = Library;
            delegates[1] = Using;
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
       
        delegate int Operation(int x, int y);
        delegate void GetMessage();
        private static void Using()
        {
            try
            {
                Show_Message(YourCode);

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Oopsie! You have an exception: {ex.Message}. We don't know what to do((( ");
            }
            finally {
                
                
            }
            Console.WriteLine("The End");
        }
        private static void Show_Message(GetMessage _del)
        {
            _del?.Invoke();
        }
        private static void YourCode()
        {
            Console.WriteLine("Write the code here!");

            Add(3,0);
        }
        private static int Add(int x, int y)
        {
            return x / y;
        }

        //private static void Using()
        //{
        //    string path, information;
        //    StreamReader reader = null;

        //    try
        //    {
        //        Console.Write("Path: ");
        //        path = Console.ReadLine();

        //        reader = new StreamReader(path);

        //        information = reader.ReadToEnd();

        //        Console.WriteLine($"Information: \n {information}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Oopsie! You have an exception: {ex.Message}. We don't know what to do(((");
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //        {

        //            reader.Dispose();
        //        }
        //    }

        //    Console.WriteLine("The End :D");
        //}
        static void Drawing()
        {
            Console.Clear();
            var buf = "";
            var kode = 0;
            while (true)
            {
                Console.WriteLine("1 - Triangle.\n2 - Rectangle.\n3 - Sphere.");
                try
                {
                    buf = Console.ReadLine();
                    kode = Convert.ToInt32(buf);
                    break;
                }
                //
               
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\nMaybe you didn't enter anything, or you entered a letter. Please enter numbers from 1-3");
                }
            }
            string buff = "";
            uint lenght = 0;
            uint width = 0;
            Opshibka prov = new Opshibka();
            switch (kode)
            {
                case 1:
                    Triangle tr = new Triangle();
                    while (true)
                    {
                        Console.WriteLine("Enter the length of the first Cathetus");
                        buff = Console.ReadLine();
                        try
                        {
                            lenght = Convert.ToUInt32(buff);
                            if (prov.Input(lenght))
                            {
                                tr.Draw(lenght);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("We cannot draw a square for such values ​​enter length and width > 2 The number is too large");
                            }                    
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"You didn't enter a number or your number <0 or number is not an integer \n{ex.Message}");
                        }
                    }
                    break;
                case 2:
                    Cube cb = new Cube();                 
                    while (true)
                    {
                        Console.WriteLine("Enter Length");
                        buff = Console.ReadLine();
                        try
                        {
                            lenght = Convert.ToUInt32(buff);
                            Console.WriteLine("Enter Width");
                            buff = Console.ReadLine();
                            try
                            {
                                width = Convert.ToUInt32(buff);
                                                          
                                if (prov.Input(width, lenght))
                                {
                                    cb.Draw(width, lenght);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("We cannot draw a square for such values ​​enter length and width > 2 or The number is too large");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"You didn't enter a number or your number <0 or number is not an integer \n{ex.Message}");
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"You didn't enter a number or your number <0 or number is not an integer\n{ex.Message}");
                        }
                        
                    }
                    break;
                case 3:
                    Sphere sph = new Sphere();                    
                    ulong r;
                    Console.WriteLine("Enter radius");                  
                    
                    buff = Console.ReadLine();
                    try
                    {

                        r = Convert.ToUInt32(buff);
                        if (prov.Input((uint)r))
                        {
                            sph.Draw(r);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("We cannot draw a square for such values ​​enter length and width > 2 The number is too large");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"You didn't enter a number or your number <0  \n{ex.Message}");
                    }              
                    break;
                default:
                    Console.WriteLine("OOOOoooops we do not know such figures(");
                   break;

            }
            
        }
            
        }

    

    class Opshibka
    {
        public bool Input(uint x, uint y)
        {
            if (x <= 2 || y <= 2 && x >= 81 && y >= 81) return false;
            else return true;
        }

        public bool Input(uint x)
        {
            if (x <= 2 && x >= 40) return false;
            else return true;
        }

    }



    class Triangle
    {
        public void Draw(uint first )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (var i = 0; i < first; i++)
            {
                for (var j = 0; j < i; j++) Console.Write('0');
                Console.WriteLine();
            }
        }
    }

    class Cube
    {
        public void Draw(uint width, uint lenght)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (var i = 0; i < lenght; i++)
            {
                for (var j = 0; j < width; j++) Console.Write("0 ");
                Console.WriteLine();
            }
        }
    }

   class Sphere
        {

            public void Draw(ulong r)
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var r_in = r - 0.4;
            var r_out = r + 0.4;
            var minR = (int)r;

                for (var y = (int)r; y >= -minR; --y)
                {
                    for (var x = (double)-minR; x < r_out; x += 0.5)
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



