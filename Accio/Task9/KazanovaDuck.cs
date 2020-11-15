using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    class KazanovaDuck : Duck
    {
        public KazanovaDuck(string l) : base(l)
        {
            Live = l;
        }
        public override void GetRoar()
        {
            Console.WriteLine("Kazanova Live");
        }
    }
}
