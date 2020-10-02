using System;

namespace Third
{
    class Program
    {

        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            int code;

            while (true)
            {
                Console.WriteLine("1 - Counter.\n2 - Generic.\n3 - Ducks.\n0 - Exit.");
                Console.Write("Answer: ");
                int.TryParse(Console.ReadLine(), out code);
                switch (code)
                {
                    case 1:
                        first();
                        break;
                    case 2:
                        second();
                        break;
                    case 3:
                        third();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }

                Console.ReadKey(true);
                Console.Clear();

            }
        }
        static void first()
        {
            Func();
            Console.WriteLine($"Create objects: {A.count}");
        }

        static void second()
        {

        }

        static void third()
        {
            Console.Clear();
            Duck[] ducks = new Duck[5];
            RubberDuck rbDuck = new RubberDuck();
            GrayDuck gDuck = new GrayDuck();
            KazanovaDuck kDuck = new KazanovaDuck();
            BlueDuck blDuck = new BlueDuck();
            FatDuck ftDuck = new FatDuck();

            ducks[0] = rbDuck;
            ducks[1] = gDuck;
            ducks[2] = blDuck;
            ducks[3] = ftDuck;
            ducks[4] = kDuck;

            
            Console.WriteLine("HAHAHAHAHA, IT'S A TRAP!!!");
            while (true)
            {
                var cki = Console.ReadKey(true);
                if (cki.KeyChar == 'q') break;
                ducks[new Random().Next(5)].GetRoar();
            }

        }
        public static void Func()
        {
            A someobjects = new A();
            A anyobjects = new A();
            A anybjects = new A();
        }
    }

    class Duck
    {
        public string roar { get; set; }

        public virtual void GetRoar()
        {
            Console.WriteLine("Auf");
        }
    }

    class RubberDuck : Duck
    {
        public override void GetRoar()
        {
            Console.WriteLine("Серёжа...");
        }
    }

    class GrayDuck : Duck
    {
        public override void GetRoar()
        {
            Console.WriteLine("Сбрил брови сыну...");
        }
    }

    class BlueDuck : Duck
    {
        public override void GetRoar()
        {
            Console.WriteLine("Зачем?");
        }
    }

    class FatDuck : Duck
    {
        public override void GetRoar()
        {
            Console.WriteLine("Не объяснив причину.");
        }
    }


    class KazanovaDuck : Duck
    {
        public override void GetRoar()
        {
            Console.WriteLine("ЪЕЕЕЪ");
        }
    }
   
    class A
    {
        public static int count;
        public A()
        {
            count++;
        }
    }

}