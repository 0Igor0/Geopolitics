using Geopolitics.Models;
using Geopolitics.Context;
using Geopolitics.Repositories.Interfaces;

namespace Geopolitics.Repositories
{
    public class ContinentRepository : IContinentRepository
    {
        private readonly AppDbContext _context;

        public ContinentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Continent> Continents => _context.Continents;
    }
}
