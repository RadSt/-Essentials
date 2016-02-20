using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Threading;

namespace Task2
{
    public class Presenter
    {
        private Model model = null;
        private MainWindow mainWindow = null;
        private DispatcherTimer timer = null;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model=new Model();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(timerTick);
            this.mainWindow.StartEvent += MainWindow_StartEvent;
            this.mainWindow.StopEvent += MainWindow_StopEvent;
            this.mainWindow.ResetEvent += MainWindow_ResetEvent;

        }

        private void MainWindow_ResetEvent(object sender, EventArgs e)
        {
            model.Reset();
            timer.IsEnabled = true;
        }

        private void MainWindow_StopEvent(object sender, EventArgs e)
        {
            timer.IsEnabled = false;
        }

        private void MainWindow_StartEvent(object sender, EventArgs e)
        {
            timer.IsEnabled = true;
        }

        void timerTick(object sender, EventArgs e)
        {
            mainWindow.LblTime.Content=model.Tick();
        }
    }
}