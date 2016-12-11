using BeerSearcher.AndroidCore.ViewModels;
using Cirrious.MvvmCross.Interfaces.ViewModels;
using Cirrious.MvvmCross.ViewModels;

namespace BeerSearcher.AndroidCore
{
    public class StartApplication : MvxApplicationObject, IMvxStartNavigation
    {
        public void Start()
        {
            RequestNavigate<SearchViewModel>();
        }

        public bool ApplicationCanOpenBookmarks { get { return true; } }
    }
}