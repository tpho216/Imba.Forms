using System;
using Imba.Core.ViewModels.IoTCalibration;
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
            GoToStartIoTCalibrationVMCommand = new MvxCommand(GoToStartIoTCalibrationVM);
            ExitViewModelsCommand = new MvxCommand(ExitViewModels);

            _navigationService = navigationService;
        }

        public IMvxCommand GoToStartIoTCalibrationVMCommand { get; private set; }
        public IMvxCommand ExitViewModelsCommand { get; private set; }

        private void GoToStartIoTCalibrationVM()
        {
            _navigationService.Close(this);
            _navigationService.Navigate<StartIoTCalibrationViewModel>();
        }

        private void ExitViewModels()
        {
            _navigationService.Close(this);
            _navigationService.Navigate<ExitIoTCalibrationViewModel>();
        }
    }
}
