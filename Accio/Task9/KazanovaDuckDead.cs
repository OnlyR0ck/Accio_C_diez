using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    class KazanovaDuckDead : Duck
    {
        public KazanovaDuckDead(string l) : base(l)
        {
            Live = l;
        }
        public override void GetRoar()
        {
            Console.WriteLine("Kazanova Dead");
        }
    }
}
