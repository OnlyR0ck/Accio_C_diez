using System;

namespace Third
{
    class Program
    {

     

        static void Main(string[] args)

        {
            Menu();
        }

        static void Menu()
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
                        First();
                        break;
                    case 2:
                        Second();
                        break;
                    case 3:
                        Third();
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
        static void First()
        {
            Func();
            Console.WriteLine($"Create objects: {A.count}");
        }

        static void Second()
        {
            Safe<object, object, object> safe = new Safe<object, object, object>( true, 25, "Lox");
            
                
            safe.Veiw();
        }

        static void Third()
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
        public string Roar { get; set; }

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

    class Safe<TB,TD,TS>
    {
        private readonly TB _worker;
        private readonly TD _age;
        private readonly TS _fio;

        public Safe(TB wrk, TD ag, TS fi)
        {
            _worker = wrk;
            _age = ag;
            _fio = fi;
        }

       public void Veiw()
        {
            Console.WriteLine($"Can work"+ _worker + "\nFIO" + _fio +"\nAge" + _age);
        }

    }

}
