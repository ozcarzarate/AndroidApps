using Android.App;
using BeerSearcher.AndroidCore.ViewModels;
using Cirrious.MvvmCross.Binding.Droid.Views;

namespace BeerSearcherApp.Views
{
    [Activity(Label = "Beer Searcher")]
    public class BeerView : MvxBindingActivityView<BeerViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Beer);
        }
    }
}