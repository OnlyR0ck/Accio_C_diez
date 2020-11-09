using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Notes : IAsyncDisposable
    {
        private int delay { get; set; }
        public int frequency;
        public int duration;

        public Notes()
        {
            delay = 100;
            frequency = 500;
            duration = 100;
        }

        public Notes(int fr, int dur, int del)
        {
            this.frequency = fr;
            this.duration = dur;
            this.delay = del;
        }

        public async ValueTask DisposeAsync()
        {
            Task.Delay(delay);
            Console.Beep(frequency, duration);
            GC.SuppressFinalize(this);
        }

        ~Notes()
        {
            DisposeAsync();
        }
    }
}
