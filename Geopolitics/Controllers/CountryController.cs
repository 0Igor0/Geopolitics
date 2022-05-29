using Geopolitics.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Geopolitics.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public IActionResult List()//para poder acessar o banco de dados eu cria essa instancia que faz a conexão com o repository que acessa o banco de dados
        {
            var countries = _countryRepository.Countries;
            return View(countries);
        }
    }
}
