using Geopolitics.Models;

namespace Geopolitics.Repositories.Interfaces
{
    public interface ICountryRepository
    {
        IEnumerable<Country> Countries { get; }
        IEnumerable<Country> CountriesSelecionados { get; }
        Country GetCountryById(int lancheId);
    }
}
