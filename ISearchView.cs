using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR1
{
    interface ISearchView : IView
    {
        event Action OpenedSearchPlanet;
         event Action<string> SearchedPlanet; 
        void UpdateListView(string name, string equatorialDiameter, string mass, string orbitalRadius, string rotationPeriod, string countSatellites, string typePlanet);
    }
}
