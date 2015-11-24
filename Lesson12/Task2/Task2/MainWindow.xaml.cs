using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public event EventHandler StartEvent = null;
        public event EventHandler StopEvent = null;
        public event EventHandler ResetEvent = null;

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            StartEvent(sender, e);
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            StopEvent(sender, e);
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetEvent(sender, e);
        }
    }
}
