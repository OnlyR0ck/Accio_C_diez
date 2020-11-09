using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelperLibrary;
using System.Threading;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegates = new Menu.MenuDelegate[] {PlayNotes,RUN, Drawing };
            Menu.StartMenu(delegates);
        }
        
        static int Menu2()
        {
            Console.WriteLine("1 - Triangle.\n2 - Rectangle.\n3 - Sphere. \n4 - Exit");
            string code = Console.ReadLine();
            int code1 = int.Parse(code);
            return code1;
        }

        static void Drawing()
        {
            string buff = "";
            uint lenght = 0;
            uint width = 0;
            Opshibka prov = new Opshibka();
            while (true)
            {
                Console.Clear();
                switch (Menu2())
                {
                    case 1:
                        Triangle tr = new Triangle();
                        Console.WriteLine("Enter the length of the first Cathetus");
                        buff = Console.ReadLine();
                        try
                        {
                            lenght = Convert.ToUInt32(buff);
                            if (prov.Input(lenght))
                            {
                                tr.Draw(lenght);

                                tr.Dispose();
                                Console.WriteLine("Wait");
                                Thread.Sleep(3000);
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
                                        cb.Dispose();
                                        Thread.Sleep(3000);
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
                                sph.Dispose();
                                Thread.Sleep(3000);
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
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("OOOOoooops we do not know such figures(");
                        break;

                }
                Console.WriteLine("Wait 3 seconds please");
                Thread.Sleep(3000);
            }

        }
        static void PlayNotes()
        {
            var fr = new float[]{ 659.255f, 659.255f, 659.255f, 523.251f, 659.255f, 783.991f, 391.995f, 523.251f, 391.995f, 329.628f, 440, 493.883f, 466.164f, 440, 391.995f, 659.255f, 783.991f, 880, 698.456f, 783.991f, 659.255f, 523.251f, 587.33f, 987.767f, 783.991f, 680.255f, 698.456f, 622.254f, 680.255f, 415.305f, 466.164f, 523.251f, 440, 523.251f, 587.33f, 783.991f, 739.989f, 729.989f, 587.33f, 659.255f, 1046.502f, 1046.502f, 1046.502f };
            var dur = new int[]{ 300, 300, 160, 160, 300, 300, 300, 300, 300, 300, 300, 300, 160, 300, 300, 300, 300, 300, 160, 160, 300, 160, 160, 160, 300, 300, 160, 300, 160, 300, 300, 300, 300, 300, 300, 300, 300, 160, 300, 300, 300, 160, 300 };
            var del = new int[]{ 35, 35, 50, 35, 35, 350, 200, 35, 35, 200, 35, 35, 35, 200, 35, 35, 35, 35, 35, 200, 35, 35, 35, 35, 35, 35, 35, 35, 200, 35, 35, 35, 35, 35, 200, 35, 35, 35, 35, 200, 35, 35, 0 };
            List<Notes> notes = new List<Notes>();
            for (int i = 0; i < fr.Length; i++)
            {
                notes.Add(new Notes((int) fr[i], dur[i], del[i]));
            }

            for (int i = 0; i < fr.Length; i++)
            {
                notes[i].DisposeAsync();
            }

            string bigText = @" 
 ___                                                                   ___                        
(  _`\                               /'\_/`\              _           (  _`\                      
| (_(_) _   _  _ _      __   _ __    |     |   _ _  _ __ (_)   _      | (_) ) _ __   _     ___    
`\__ \ ( ) ( )( '_`\  /'__`\( '__)   | (_) | /'_` )( '__)| | /'_`\    |  _ <'( '__)/'_`\ /',__)   
( )_) || (_) || (_) )(  ___/| |      | | | |( (_| || |   | |( (_) )   | (_) )| |  ( (_) )\__, \ _ 
`\____)`\___/'| ,__/'`\____)(_)      (_) (_)`\__,_)(_)   (_)`\___/'   (____/'(_)  `\___/'(____/(_)
              | |                                                                                 
              (_)                                                                                 ";

            ConsoleColor[] colors =
                {ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue,ConsoleColor.DarkBlue,ConsoleColor.DarkMagenta};

            for (int i = 0,j = 0;i<bigText.Length;i++, j++)
            {
                if (j == colors.Length - 1) j = 0;
                Console.ForegroundColor = colors[j];
                Console.Write(bigText[i]);
            }

        }

        static void RUN()
        {
            FirstTask aFirstTask = new FirstTask();
            aFirstTask.Running();
        }
    }

}
