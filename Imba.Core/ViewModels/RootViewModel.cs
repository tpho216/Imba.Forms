using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;

namespace Imba.Core.ViewModels
{
    public class RootViewModel : BaseNavigationViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public RootViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService ) : base  (logProvider, navigationService)
        {
            _navigationService = navigationService;
            ShowSettingsViewModelCommand = new MvxCommand(ShowSettingsViewModels);

        }
        // MVVM Commands
        public IMvxCommand ShowSettingsViewModelCommand { get; private set; }

        public override Task Initialize()
        {
            return base.Initialize();
        }

        public override void Prepare()
        {
            base.Prepare();
        }

        // Private methods
        private void ShowSettingsViewModels()
        {
            _navigationService.Navigate<SettingsViewModel>();
        }
    }
}

    