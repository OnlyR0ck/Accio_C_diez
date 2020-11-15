using System;

namespace Task9
{
    public  class People
    {
        public bool Liars;
        public static int Lia = 0;
        public static int Hon = 0;

        public void Many()
        {
            Console.WriteLine($"In Game {Lia} Liars and {Hon} not a Liars");
        }
        public void Clear()
        {
            Lia = 0;
            Hon = 0;
        }
    }

    public class Liars : People
    {
        public Liars()
        {
            Lia += 1;
        }
        public void PrevNext(bool liars)
        {
            if (liars)
            {
                Console.WriteLine(" man is not a liar");
            }
            else
            {
                Console.WriteLine(" man is a liar");
            }
        }
    }

    public class Honest : People
    {
        public Honest()
        {
            Hon += 1;
        }
        public void PrevNext(bool liars)
        {
            if (liars)
            {
                Console.WriteLine(" man is a liar");
            }
            else
            {
                Console.WriteLine(" man is not a liar");
            }
        }
    }



}