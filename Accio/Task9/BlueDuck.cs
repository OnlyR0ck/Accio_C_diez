﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    class BlueDuck : Duck
    {
        public BlueDuck(string l) : base(l)
        {
            Live = l;
        }
        public override void GetRoar()
        {
            Console.WriteLine("Blue Live");
        }
    }
}
