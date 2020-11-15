using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    class RubberDuck : Duck
    {
        public RubberDuck(string l) : base(l)
        {
            Live = l;
        }
        public override void GetRoar()
        {
            Console.WriteLine("Rubber Live");
        }
    }
}
