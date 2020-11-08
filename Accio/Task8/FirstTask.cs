using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task8
{
    
    public class FirstTask
    {
        public static bool finish = false;

        public void Running()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ready");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Set");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Go!!!!!");
            Console.ResetColor();
            Thread.Sleep(100);

            Running3();
            Running97();
        }

        static async void Running3()
        {
            await Task.Run(() => {

                for (int i = 0; i < 51; i++)
                {
                   // Thread.Sleep(100);
                    Console.WriteLine(3);
                    if(finish){break;}
                }

                if (finish!=true)
                {
                    finish = true;
                    Result(3);
                }
                
                

            });
        }

       static async void Running97()
       {
           await Task.Run(() =>
           {
               for (int i = 0; i < 51; i++)
               {
                   Console.WriteLine(97);
                   if (finish) { break; }
               }
               if (finish != true)
               {
                   finish = true;
                   Result(97);
               }
              

           });
       }

       static void Result(int n)
       {
           Console.ForegroundColor = ConsoleColor.Cyan;
           Console.WriteLine($"{n} win!!!!!");
           Console.ResetColor();
        }
    }


}