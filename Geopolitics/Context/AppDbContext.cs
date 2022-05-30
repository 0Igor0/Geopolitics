using Geopolitics.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Geopolitics.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //esse arquivo/classe AppDbContext, carrega informações de configurações do dbContext e define quais são as classes que estou mapeando e para quais tabelas
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<SelectedCountries> SelectedCountries { get; set; }
    }
}
