using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    class RubberDuckDead : Duck
    {
        public RubberDuckDead(string l) : base(l)
        {
            Live = l;
        }
        public override void GetRoar()
        {
            Console.WriteLine("Rubber Dead");
        }
    }
}
