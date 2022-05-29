using Geopolitics.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Geopolitics.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}