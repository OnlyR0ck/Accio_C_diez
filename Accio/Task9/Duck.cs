using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    [DeadOrLiveDuck(Live = "Live")]
    class Duck
    {        
        public string Live { get; set; }
        public Duck(string l)
        {
            Live = l;
        }

        public virtual void GetRoar()
        {
            Console.WriteLine("Auf");
        }
    }
}
