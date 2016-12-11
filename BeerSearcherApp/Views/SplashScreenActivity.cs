using Android.App;
using Cirrious.MvvmCross.Droid.Views;

namespace BeerSearcherApp.Views
{
    [Activity(Label = "BeerSearcherApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity : MvxBaseSplashScreenActivity
    {
        public SplashScreenActivity()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}