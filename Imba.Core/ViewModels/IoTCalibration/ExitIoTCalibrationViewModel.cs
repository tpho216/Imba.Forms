using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;

namespace Imba.Core.ViewModels.IoTCalibration
{
    public class ExitIoTCalibrationViewModel : BaseNavigationViewModel
    {
        private readonly IMvxNavigationService _navigationService;
       
        public ExitIoTCalibrationViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            _navigationService = navigationService;
            ExitViewModelsCommand = new MvxCommand(ExitViewModels);
            BackToPreviousViewModelsCommand = new MvxCommand(BackToPreviousViewModels);
        }

        // MvvmCross Lifecycle

        public override Task Initialize()
        {
            return base.Initialize();
        }

        // MVVM Properties

        // MVVM Commands
        public IMvxCommand ExitViewModelsCommand { get; private set; }
        public IMvxCommand BackToPreviousViewModelsCommand { get; private set; }
        // Private methods
        private void ExitViewModels()
        {
            _navigationService.Close(this);
        }

        private void BackToPreviousViewModels()
        {
            _navigationService.Close(this);
            _navigationService.Navigate<IoTCalibrationViewModel>();
            //TODO this is not a perfect situation where the ViewModel has to
            //be re-created again. Depending on the service it might be okay :D
            //TODO furthermore, the current ExitViewModel doesn't know which
            //one is previous ViewModel so the best work around is delegate this
            //task to the service. Something like Service.NavigationRoute
        }
    }
}
