using HomeWork.Models;
using HomeWork.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Controllers;

public class SeaFoodController : Controller
{
    private readonly IFoodServices _seaFoodService;

    public SeaFoodController(IFoodServices seaFoodService)
    {
        _seaFoodService = seaFoodService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var seaFoods = _seaFoodService.GetAll();
        return View(seaFoods);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(SeaFood seaFood)
    {
        _seaFoodService.Add(seaFood);

        return RedirectToAction("Index");
    }
}