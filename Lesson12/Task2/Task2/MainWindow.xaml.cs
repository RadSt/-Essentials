using System;
using System.Windows;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Presenter Presenter
        {
            get { throw new NotImplementedException(); }
            set { }
        }
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler StartEvent = null;
        public event EventHandler StopEvent = null;
        public event EventHandler ResetEvent = null;

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            StartEvent.Invoke(sender, e);
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            StopEvent.Invoke(sender, e);
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetEvent.Invoke(sender, e);
        }
    }
}
