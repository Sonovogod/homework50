namespace HomeWork.Models;

public class CustomerOrder
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string Adress { get; set; }
    public string PhoneNumber { get; set; }

    public int SeaFoodId { get; set; }
    public SeaFood SeaFood { get; set; }
}