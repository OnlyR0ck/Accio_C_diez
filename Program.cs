using System;
using System.Collections.Generic;

namespace Task_2._1
{
    class Stack
    {

        static void Ochered()
        {
            Queue<int> qe = new Queue<int>();
            Console.WriteLine("Enter the number: ");
            string q0 = Console.ReadLine();
            var n = Convert.ToInt32(q0);
            for (int i = 1; i <= n; i++)
            {
                string a0 = Console.ReadLine();
                var a = Convert.ToInt32(a0);
                qe.Enqueue(a);
            }
            Console.Clear();
            Console.WriteLine("Source Queue: ");
            foreach (int s in qe)
            {
                Console.Write(" ");
                Console.Write(s);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Now in Queue {0} numbers", qe.Count);

            while (qe.Count>0)
            {
                Console.WriteLine("Pop - {0}", qe.Dequeue());
            }
            if (qe.Count == 0)
            {
                Console.WriteLine("\n No Queue");
            }
            Console.WriteLine("Tap any key...");
        }
        static void Steck()
        {
            var MyStack = new Stack<int>();
            Console.WriteLine("Enter the number: ");
            string q0 = Console.ReadLine();
            var n = Convert.ToInt32(q0);
            for (int i = 1; i <= n; i++)
            {
                string a0 = Console.ReadLine();
                var a = Convert.ToInt32(a0);
                MyStack.Push(a);
            }
            Console.Clear();
            Console.WriteLine("Source Stack: ");
            foreach (int s in MyStack)
            {
                Console.Write(" ");
                Console.Write(s);
            }
            Console.WriteLine("\n");

            while (MyStack.Count > 0)
            {
                Console.WriteLine("Pop - {0}", MyStack.Pop());
            }
            if (MyStack.Count == 0)
            {
                Console.WriteLine("\n No stack");
            }
            Console.WriteLine("Tap any key...");
        }
        static int Main()
        {
            
            
            while (true)
            {
                Console.WriteLine("1) Stack\n2) Queue \n3)Exit");

                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Steck();
                        break;
                    case 2:
                        Ochered();
                        break;
                    case 3: 
                        return -1;
                        
                    default:
                        Console.WriteLine("vibiri pravilno");
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}
