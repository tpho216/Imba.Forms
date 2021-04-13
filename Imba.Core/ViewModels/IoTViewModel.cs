using System;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Imba.Core.ViewModels
{
    public class IoTViewModel : BaseNavigationViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IoTViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            _navigationService = navigationService;
            //ShowIoTViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<IoTViewModel>());

        }
        // MvvmCross Lifecycle

        // MVVM Properties

        // MVVM Commands
        //public IMvxAsyncCommand ShowIoTViewModelCommand { get; private set; }
        // Private methods

    }
}
