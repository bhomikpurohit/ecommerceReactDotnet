using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace OfficialShoppingApp.Models;

public class Products
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public int Quantity { get; set; }
    public DateOnly ExpDate { get; set; }
    public string ImageUrl { get; set; }
    public int Status { get; set; }
    
}