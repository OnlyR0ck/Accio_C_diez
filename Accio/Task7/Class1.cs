using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    class Rainbow : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "Red";
            yield return "Orange";
            yield return "Yellow";
            yield return "Green";
            yield return "Cyan";
            yield return "Blue";
            yield return "Purple";
        }
    }
}
