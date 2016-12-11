using Android.Content;
using BeerSearcher.AndroidCore;
using Cirrious.MvvmCross.Binding.Droid;

namespace BeerSearcherApp
{
    public class Setup : MvxBaseAndroidBindingSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override Cirrious.MvvmCross.Application.MvxApplication CreateApp()
        {
            return new BeerSearcherApplication();
        }
    }
}