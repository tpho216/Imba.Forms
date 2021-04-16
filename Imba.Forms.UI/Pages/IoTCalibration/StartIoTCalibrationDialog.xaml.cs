﻿using System;
using System.Collections.Generic;
using Imba.Core.ViewModels.IoTCalibration;
using MvvmCross.Commands;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms;

namespace Imba.Forms.UI.Pages.IoTCalibration
{
    [MvxModalPresentation(WrapInNavigationPage = false, NoHistory = false)]
    public partial class StartIoTCalibrationDialog : MvxContentPage<StartIoTCalibrationViewModel>
    {
        public StartIoTCalibrationDialog()
        {
            InitializeComponent();
        }
    }
}
