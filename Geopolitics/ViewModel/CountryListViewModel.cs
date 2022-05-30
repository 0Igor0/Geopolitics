using Geopolitics.Models;

namespace Geopolitics.ViewModel
{
    public class CountryListViewModel
    {
        public IEnumerable<Country>  Countries { get; set; }
        public string CurrentContinent { get; set; }
    }
}
