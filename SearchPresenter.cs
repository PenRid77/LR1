using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    class SearchPresenter : IPresenter
    {
        private readonly ISearchView _view;
        private readonly ISearchModel _module;

        public SearchPresenter(ISearchView view, ISearchModel module)
        {
            _view = view;
            _module = module;
            _view.SearchedPlanet += SearchPlanet;
        }

        public void Run()
        {
            _view.Show();
        }
        private void SearchPlanet(string namePlanet)
        {
            Planet findedPlanet = _module.FindPlanetInLibrary(namePlanet);
            if(findedPlanet != null) _view.UpdateListView(findedPlanet.Name, findedPlanet.EquatorialDiameter.ToString(), findedPlanet.Mass.ToString(), findedPlanet.OrbitalRadius.ToString(), findedPlanet.RotationPeriod.ToString(), findedPlanet.CountSatellites.ToString(), PlanetData.GetTypePlanet(findedPlanet.TypePlanet));
        }
    }
}
