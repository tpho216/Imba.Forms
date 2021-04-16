using System;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Imba.Core.ViewModels
{
    public class BaseNavigationViewModel : MvxNavigationViewModel 
    {
        public BaseNavigationViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base (logProvider, navigationService)
        {
        }
    }
}
