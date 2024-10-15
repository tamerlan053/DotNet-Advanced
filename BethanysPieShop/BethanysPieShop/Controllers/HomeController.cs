using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers : Controller
{
    public class HomeController
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Pie> piesOfTheWeek = _pieRepository.GetPiesOfTheWeek();
            var model = new HomeViewModel { PiesOfTheWeek = piesOfTheWeek };
            return View(model);
        }
    }
}
