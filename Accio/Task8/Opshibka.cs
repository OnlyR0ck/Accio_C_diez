using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Opshibka
    {
        public bool Input(uint x, uint y)
        {
            if (x <= 2 || y <= 2 && x >= 81 && y >= 81) return false;
            else return true;
        }

        public bool Input(uint x)
        {
            if (x <= 2 && x >= 40) return false;
            else return true;
        }


    }
}
