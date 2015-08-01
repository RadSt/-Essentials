using Core.Services;
using DesktopApp1.Services;
using MVVMbasics;
using MVVMbasics.Services;

namespace DesktopApp1
{
    public partial class App : BaseApplication
    {
        public App()
        {
            // MVVMbasics-specific initialization
            NavigatorService navigatorService = new NavigatorService();
            //TODO: Modify the following line to automatically or manually register your Views
            navigatorService.RegisterAll("DesktopApp1.Views.*");
            Services.Register(navigatorService);
            Services.Register<MessageboxService>();
            //TODO: Modify the following lines to automatically or manually register your Services
            Services.Register<SamplePlatformspecificService>();
            Services.Register<SamplePortableService>();
        }
    }
}
