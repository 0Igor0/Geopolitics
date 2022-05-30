using Geopolitics.Repositories.Interfaces;
using Geopolitics.ViewModel;
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
            ViewBag.Total = "Total countries";
            ViewBag.TotalCountries = countries.Count();
            ViewData["Title"] = "Every Countries";

            var countriesListViewModel = new CountryListViewModel();
            countriesListViewModel.Countries= _countryRepository.Countries;
            countriesListViewModel.CurrentContinent = "Current Continent";

            return View(countriesListViewModel);
        }
    }
}
