using HomeWork.Models;

namespace HomeWork.Services;

public class CustomerOrderService 
{
    private readonly FoodContext _db;

    public CustomerOrderService(FoodContext db)
    {
        _db = db;
    }
    
    public void Add(int id)
    {
    }
}