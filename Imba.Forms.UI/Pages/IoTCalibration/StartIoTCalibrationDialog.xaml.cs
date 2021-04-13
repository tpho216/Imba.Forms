using System;
using System.Collections.Generic;
using Imba.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms;

namespace Imba.Forms.UI.Pages.IoTCalibration
{
    public partial class StartIoTCalibrationDialog : MvxContentPage<IoTViewModel>
    {
        public StartIoTCalibrationDialog()
        {
            InitializeComponent();
        }
    }
}
