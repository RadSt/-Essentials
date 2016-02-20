using System;
using System.Windows;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public event EventHandler Minus=null;
        public event EventHandler Umnozit = null;
        public event EventHandler Delit = null;
        public event EventHandler Plus = null;
        public event EventHandler Result = null;
        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            Minus.Invoke(sender,e);
        }

        private void BtnUmnozit_Click(object sender, RoutedEventArgs e)
        {
            Umnozit.Invoke(sender,e);
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            Plus.Invoke(sender,e);
        }

        private void BtnDelit_Click(object sender, RoutedEventArgs e)
        {
            Delit.Invoke(sender,e);
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            Result.Invoke(sender,e);
        }
    }
}
