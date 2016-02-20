using System;
using System.Windows;

// View

namespace MVP
{    
    public partial class MainWindow : Window
    {
        private EventHandler myEvemt = null;

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

        public event EventHandler myEvent
        {
            add { myEvemt += value; }
            remove { myEvemt -= value; }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myEvemt.Invoke(sender, e);
        }
    }
}
