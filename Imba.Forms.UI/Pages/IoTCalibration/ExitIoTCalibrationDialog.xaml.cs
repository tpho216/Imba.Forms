﻿using System;
using Imba.Core.ViewModels.IoTCalibration;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;

namespace Imba.Forms.UI.Pages.IoTCalibration
{
    [MvxModalPresentation(WrapInNavigationPage = false, NoHistory = false)]
    public partial class ExitIoTCalibrationDialog : MvxContentPage<ExitIoTCalibrationViewModel>
    {
        public ExitIoTCalibrationDialog()
        {
            InitializeComponent();
        }
    }
    
}
