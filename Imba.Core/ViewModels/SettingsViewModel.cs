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
            ShowIoTViewModelCommand = new MvxCommand(ShowIoTViewModel);
            _navigationService = navigationService;
        }

        public IMvxCommand ShowIoTViewModelCommand { get; private set; }

        private void ShowIoTViewModel()
        {
            _navigationService.Navigate<IoTViewModel>();
        }

    }
}
