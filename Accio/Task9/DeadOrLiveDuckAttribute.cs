using System;
using System.Collections.Generic;
using System.Text;

namespace Task9
{
    public class DeadOrLiveDuckAttribute : System.Attribute
    {
        public string Live { get; set; }
        public DeadOrLiveDuckAttribute()
        { }
    }
}
