using Xamarin.Forms;
using Xamarin.Essentials;
namespace Imba.Forms.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var screenWidth = mainDisplayInfo.Width;
            var density = mainDisplayInfo.Density;
            var fullScreenWidth = screenWidth / density;
            Resources.Add("FullScreenWidth", fullScreenWidth);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
