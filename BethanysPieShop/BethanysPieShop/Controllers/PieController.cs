using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers;

public class PieController : Controller
{
    private readonly IPieRepository _pieRepository;

    public PieController(IPieRepository pieRepository)
    {
        _pieRepository = pieRepository;
    }

    public async Task<IActionResult> List(string category)
    {
        ViewBag.Title = "Pies";
        IEnumerable<Pie> allPies = await _pieRepository.GetAllAsync();

        if (string.IsNullOrEmpty(category))
        {
            return View(new PieListViewModel("All pies", allPies));
        }

        IEnumerable<Pie> piesOfCategory = allPies.Where(pie => pie.Category.CategoryName == category);
        return View(new PieListViewModel(category, piesOfCategory));
    }

    public IActionResult Details(int id)
    {
        Pie? pie = _pieRepository.GetById(id);
        if (pie is null)
        {
            return NotFound();
        }

        return View(pie);
    }

    public IActionResult Search()
    {
        return View();
    }
}
