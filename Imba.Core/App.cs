using Imba.Core.ViewModels;
using MvvmCross.ViewModels;

namespace Imba.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<RootViewModel>();
        }
    }
}