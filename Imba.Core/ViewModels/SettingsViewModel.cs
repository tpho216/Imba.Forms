using System;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;

namespace Imba.Core.ViewModels
{
    public class SettingsViewModel : BaseNavigationViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public SettingsViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            ShowIoTViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<IoTViewModel>());
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand ShowIoTViewModelCommand { get; private set; }

    }
}
