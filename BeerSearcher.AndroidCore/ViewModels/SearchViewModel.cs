using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using BeerSearcher.AndroidCore.Entities;
using Cirrious.MvvmCross.Commands;
using Cirrious.MvvmCross.ViewModels;

namespace BeerSearcher.AndroidCore.ViewModels
{
    public class SearchViewModel : MvxViewModel
    {
        private readonly IList<Beer> _allBeers = new List<Beer>
                                         {
                                             new Beer { BreweryName = "Dogfish Head", Name = "60 Minute IPA" },
                                             new Beer { BreweryName = "Kelso", Name = "Nut Brown Lager" },
                                             new Beer { BreweryName = "Sierra Nevada", Name = "Torpedo Extra IPA" },
                                             new Beer { BreweryName = "Sixpoint", Name = "Gorilla Warfare Coffee Porter" },
                                             new Beer { BreweryName = "Sixpoint", Name = "Sweet Action" }
                                         };

        private IList<Beer> _beers;
        public IList<Beer> Beers
        {
            get { return _beers; }
            set
            {
                _beers = value;
                RaisePropertyChanged(() => Beers);
            }
        }

        private string _query;
        public string Query
        {
            get { return _query; }
            set 
            { 
                _query = value;
                RaisePropertyChanged(() => Query);
            }
        }

        public ICommand SearchCommand
        {
            get { return new MvxRelayCommand(search); }
        }

        public ICommand SelectBeerCommand
        {
            get { return new MvxRelayCommand<Beer>(selectBeer); }
        }

        private void search()
        {
            if (string.IsNullOrWhiteSpace(Query))
            {
                Beers = _allBeers;
            }
            else
            {
                Beers =
                    _allBeers
                        .Where(beer => beer.Name.ToLowerInvariant().Contains(Query.ToLowerInvariant()))
                        .ToList();
            }
        }

        private void selectBeer(Beer beer)
        {
            RequestNavigate<BeerViewModel>(
                new Dictionary<string, string>
                    {
                        {"name", beer.Name}, 
                        {"breweryName", beer.BreweryName}
                    }
                );
        }
    }
}