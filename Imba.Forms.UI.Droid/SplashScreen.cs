using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Views;

namespace Imba.Forms.UI.Droid
{
    [Activity(Label = "SplashScreen",
        NoHistory = true,
        MainLauncher = true,
        Theme = "@style/MainTheme",
        ScreenOrientation = ScreenOrientation.Portrait,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : MvxFormsSplashScreenActivity<Setup, Core.App, App>
    {
        public SplashScreen()
            : base(Resource.Layout.splash_screen)
        {
        }

        protected override Task RunAppStartAsync(Bundle bundle)
        {
            StartActivity(typeof(RootViewActivity));
            return base.RunAppStartAsync(bundle);
        }
    }
}
