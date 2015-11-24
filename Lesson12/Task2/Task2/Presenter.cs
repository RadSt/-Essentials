using System;
using System.Threading;

namespace Task2
{
    public class Presenter
    {
        public Presenter()
        {
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 5);
        }

        private void timerTick(object sender, EventArgs e)
        {
            
        }
       
    }
}