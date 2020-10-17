using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Building : IDisposable
    {
        public int Floors { get; set; }
        public int Area { get; set; }
        public int Occupents { get; set; }
        public int AreaPerson()
        {
            return Area / Occupents;
        }
        public void Dispose()
        {
            Console.WriteLine("Disposed!!!");
        }
    }
}
