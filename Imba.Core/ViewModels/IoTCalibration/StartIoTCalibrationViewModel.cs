using System;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;

namespace Imba.Core.ViewModels.IoTCalibration
{
    public class StartIoTCalibrationViewModel : BaseNavigationViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxCommand ShowIoTCalibrationVMCommand { get; private set; }
        public IMvxCommand ExitViewModelsCommand { get; private set; }

        public StartIoTCalibrationViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base (logProvider, navigationService)
        {
            _navigationService = navigationService;
            ShowIoTCalibrationVMCommand = new MvxCommand(ShowIoTCalibrationVM);
            ExitViewModelsCommand = new MvxCommand(ExitViewModels);

        }

        private void ShowIoTCalibrationVM()
        {
            _navigationService.Close(this);
            _navigationService.Navigate<IoTCalibrationViewModel>();
        }

        private void ExitViewModels()
        {
            NavigationService.Close(this);
        }

    }
}
