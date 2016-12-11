using Cirrious.MvvmCross.Application;
using Cirrious.MvvmCross.ExtensionMethods;
using Cirrious.MvvmCross.Interfaces.ServiceProvider;
using Cirrious.MvvmCross.Interfaces.ViewModels;

namespace BeerSearcher.AndroidCore
{
    public class BeerSearcherApplication : MvxApplication, IMvxServiceProducer
    {
        public BeerSearcherApplication()
        {
            this.RegisterServiceInstance<IMvxStartNavigation>(new StartApplication());
        }
    }
}