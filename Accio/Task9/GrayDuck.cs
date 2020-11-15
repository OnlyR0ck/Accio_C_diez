using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    class GrayDuck : Duck
    {
        public GrayDuck(string l) : base(l)
        {
            Live = l;
        }
        public override void GetRoar()
        {
            Console.WriteLine("Gray Live");
        }

    }
}
