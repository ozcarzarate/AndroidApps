using Cirrious.MvvmCross.ViewModels;

namespace BeerSearcher.AndroidCore.ViewModels
{
    public class BeerViewModel : MvxViewModel
    {
        private readonly string _name;
        private readonly string _breweryName;

        public BeerViewModel(string name, string breweryName)
        {
            _name = name;
            _breweryName = breweryName;
        }

        public string Name { get { return _name; } }
        public string BreweryName { get { return _breweryName; } }
    }
}