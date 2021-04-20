using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Imba.Core.ViewModels.IoTCalibration
{
    public class IoTCalibrationViewModel : BaseNavigationViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public IMvxCommand ExitViewModelsCommand { get; private set; }

        public IoTCalibrationViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            _navigationService = navigationService;
            ExitViewModelsCommand = new MvxCommand(ExitViewModels);
            _navigationService.BeforeClose += (s, e) => handleAfterNavigate();

            //ShowIoTCalibrationViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<IoTCalibrationViewModel>());
        }
        // MvvmCross Lifecycle

        public override Task Initialize()
        {
            return base.Initialize();
        }

        // MVVM Properties

        // MVVM Commands

        private void ExitViewModels()
        {
            _navigationService.Close(this);
            _navigationService.Navigate<ExitIoTCalibrationViewModel>();
            
        }
        // Private methods

        private void handleAfterNavigate()
        {
            
        }

    }
}
