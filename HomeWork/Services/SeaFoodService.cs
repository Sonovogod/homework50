using HomeWork.Models;
using HomeWork.Services.Abstractions;

namespace HomeWork.Services
{
    public class SeaFoodService : IFoodServices
    {
        private readonly FoodContext _db;

        public SeaFoodService(FoodContext db)
        {
            _db = db;
        }

        public List<SeaFood> GetAll()
        {
            List<SeaFood> seaFoods = _db.SeaFoods.ToList();
            return seaFoods;
        }

        public void Add(SeaFood seaFood)
        {
            _db.SeaFoods.Add(seaFood);
            _db.SaveChanges();
        }
    }
}