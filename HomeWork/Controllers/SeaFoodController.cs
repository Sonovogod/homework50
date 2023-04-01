using FluentValidation.Results;
using HomeWork.Models;
using HomeWork.Services.Abstractions;
using HomeWork.Validationd;
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
        CommonViewModel commonViewModel = new CommonViewModel();
        commonViewModel.ErrorViewModel = new ErrorViewModel();
        commonViewModel.ErrorViewModel.Request = new List<ValidationFailure>();
        return View(commonViewModel);
    }
    
    [HttpPost]
    public IActionResult Create(SeaFood seaFood)
    {
        CreateSeaFoodValidator validator = new CreateSeaFoodValidator();
        CommonViewModel commonViewModel = new CommonViewModel();
        var validationResult = validator.Validate(seaFood);
        
        if (validationResult.IsValid)
            _seaFoodService.Add(seaFood);
        else
        {
            ErrorViewModel errorViewModel = new ErrorViewModel();
            errorViewModel.Request = validationResult.Errors;
            commonViewModel.ErrorViewModel = new ErrorViewModel();
            commonViewModel.ErrorViewModel.Request = errorViewModel.Request;
            return View(commonViewModel);
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult FullInfo(int id)
    {
        return View(_seaFoodService.FullInfo(id));
    }

    [HttpGet]
    public IActionResult Order(int id)
    {
        CustomerOrder order = new CustomerOrder()
        {
            SeaFoodId = id,
            SeaFood = _seaFoodService.FullInfo(id)
        };
        return View(order);
    }

    [HttpPost]
    public IActionResult CreateOrder(CustomerOrder order)
    {
        _seaFoodService.AddOrder(order);
        return View();
    }
}