using MVVMbasics.Attributes;
using Core.Viewmodels;
using MVVMbasics.Views;

namespace DesktopApp1.Views
{
    [MvvmNavigationTarget(typeof(MainViewmodel))]
    public partial class MainWindow : BaseView
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
