using Geopolitics.Models;
using Geopolitics.Context;
using Geopolitics.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Geopolitics.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _context;//a injeção de dependencia é uma técnicapela qual o objeto fornece as dependencias de outro objto?
        public CountryRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Country> Countries => _context.Countries.Include(c => c.Continent);

        public IEnumerable<Country> CountriesSelecionados => _context.Countries.Where(c => c.IsChosen).Include(c => c.Continent);

        public Country GetCountryById(int countryId)
        {
            return _context.Countries.FirstOrDefault(c => c.CountryId== countryId);
        }
    }
}
