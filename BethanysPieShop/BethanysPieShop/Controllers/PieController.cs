using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository)
        {
            this._pieRepository = pieRepository;
        }
        public IActionResult List()
        {
            //IEnumerable<Pie> pies = _pieRepository.GetAllPies(); 
            return View();
        }
    }
}