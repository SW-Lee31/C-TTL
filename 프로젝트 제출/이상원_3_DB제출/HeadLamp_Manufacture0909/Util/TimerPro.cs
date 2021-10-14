using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Etimer = System.Windows.Forms.Timer;

namespace HeadLamp_Manufacture0909.Util
{
    class TimerPro
    {
        Timer timer;

        public TimerPro(Timer timer)
        {
            this.timer = timer;
        }

        ~TimerPro()
        {
            stoptimer();
        }

        public void stoptimer()
        {
            timer.Dispose();
        }
    }

    class ExTimer
    {
        Etimer etimer;

        public ExTimer(Etimer etimer)
        {
            this.etimer = etimer;
        }

        public void runTImer()
        {
            etimer.Start();
        }

        public void starTimer(int interval, EventHandler sender)
        {
            etimer.Interval = interval;
            etimer.Tick += new EventHandler(sender);
            etimer.Start();
        }

        public bool checkEnable()
        {
            if (etimer == null)
            {
                etimer = new Etimer();
                return false;
            }
            return true;
        }

        ~ExTimer()
        {
            stopTimer();
        }

        public void stopTimer()
        {
            etimer.Dispose();
        }
    }
}
