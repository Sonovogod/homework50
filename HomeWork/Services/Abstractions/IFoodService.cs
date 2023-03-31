using HomeWork.Models;

namespace HomeWork.Services.Abstractions;

public interface IFoodServices
{
    List<SeaFood> GetAll();
    void Add(SeaFood seaFood);

}