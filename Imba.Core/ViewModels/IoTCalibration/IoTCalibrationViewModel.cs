using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Imba.Core.DataModels;
using Imba.Core.Services.Interfaces;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace Imba.Core.ViewModels.IoTCalibration
{
    public class IoTCalibrationViewModel : BaseNavigationViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IIoTHubService _IoTHubService;

        public IMvxCommand ExitViewModelsCommand { get; private set; }

        public IoTCalibrationViewModel(IIoTHubService IoTHubService, IMvxLogProvider logProvider, IMvxNavigationService navigationService) : base(logProvider, navigationService)
        {
            _navigationService = navigationService;
            ExitViewModelsCommand = new MvxCommand(ExitViewModels);
            _IoTHubService = IoTHubService;
            _sensors = new List<Sensor>();
        }
        // MvvmCross Lifecycle
        public override void Prepare()
        {
            base.Prepare();
        }
        public override Task Initialize()
        {
            LoadSensorsTask = MvxNotifyTask.Create(LoadSensors);
            return base.Initialize();
        }

        // MVVM Properties
        private List<Sensor> _sensors;
        public List<Sensor> Sensors
        {
            get
            {
                return _sensors;
            }
            set
            {
                _sensors = value;
                RaisePropertyChanged(() => Sensors);
            }
        }


        // MVVM Commands
        public MvxNotifyTask LoadSensorsTask { get; private set; }

        private void ExitViewModels()
        {
            _navigationService.Close(this);
            _navigationService.Navigate<ExitIoTCalibrationViewModel>();
            
        }
        // Private methods

        private Task LoadSensors()
        {
            var result = _IoTHubService.GetMockedSensors();

            _sensors.AddRange(result);

            return Task.FromResult(0);
        }


    }
}
