using System;
using Android.App;
using BeerSearcher.AndroidCore.ViewModels;
using Cirrious.MvvmCross.Binding.Droid.Views;

namespace BeerSearcherApp.Views
{
    [Activity(Label = "Beer Searcher")]
    public class SearchView : MvxBindingActivityView<SearchViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Search);
        }
    }
}

