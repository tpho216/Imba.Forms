using Imba.Core.Services.Implementations;
using Imba.Core.Services.Interfaces;
using Imba.Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Imba.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            Mvx.IoCProvider.RegisterSingleton<IIoTHubService>(new IoTHubService());

            RegisterAppStart<RootViewModel>();
        }
    }
}