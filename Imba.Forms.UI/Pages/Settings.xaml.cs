using System;
using System.Collections.Generic;
using Imba.Core.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms;

namespace Imba.Forms.UI.Pages
{
    [MvxModalPresentation(WrapInNavigationPage = false, NoHistory = false)]
    public partial class Settings : MvxContentPage<SettingsViewModel>
    {
        public Settings()
        {
            InitializeComponent();
        }
    }
}
