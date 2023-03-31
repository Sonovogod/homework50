using HomeWork.Services;
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
        return View();
    }
}