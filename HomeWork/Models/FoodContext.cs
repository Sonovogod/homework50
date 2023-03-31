using Microsoft.EntityFrameworkCore;

namespace HomeWork.Models;

public class FoodContext : DbContext
{
    public DbSet<SeaFood> SeaFoods { get; set; }
    public DbSet<CustomerOrder> CustomerOrders { get; set; }

    public FoodContext(DbContextOptions<FoodContext> options) : base(options){}
}