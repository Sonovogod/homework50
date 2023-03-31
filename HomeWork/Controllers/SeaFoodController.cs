using HomeWork.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Controllers;

public class SeaFoodController : Controller
{
    private readonly SeaFoodService _seaFoodService;

    public SeaFoodController(SeaFoodService seaFoodService)
    {
        _seaFoodService = seaFoodService;
    }

    [HttpGet]
    public IActionResult Index()
    {
           
        return View();
    }
}