using Geopolitics.Models;

namespace Geopolitics.Repositories.Interfaces
{
    public interface IContinentRepository
    {
        IEnumerable<Continent> Continents { get; }
    }
}
