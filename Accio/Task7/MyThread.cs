using System;
using System.Threading;

namespace Task7
{
    class MyThread
    {
        public int Count;
        public Thread Thrd;

        public MyThread(string name, int num)
        {
            Count = 0;
            Thrd = new Thread(this.Run);
            Thrd.Name = name;
            Thrd.Start(num);
        }

        void Run(object num)
        {
            do
            {
                Console.WriteLine("   " + Thrd.Name + ", Count = " + Count);
                Count++;
                if (Count == 50)
                {
                    Console.WriteLine(Thrd.Name + "   WIN!!!");
                    Environment.Exit(0);
                }

            } while (Count <= (int)num);
            Console.WriteLine(Thrd.Name + " ready.");
        }
    }
}
