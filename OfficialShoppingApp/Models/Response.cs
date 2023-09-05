namespace OfficialShoppingApp.Models;

public class Response
{
    public int StatusCode { get; set; }
    public string StatusMessage { get; set; }


   
    // this list will be for admin panel :)
    // this will return a particular user on parameter basis
    
    //Users
    public List<Users> listUsers { get; set; }
    public Users user { get; set; }
    //Products
    public List<Products> listProducts { get; set; } 
    public Products product { get; set; }
    //Cart
    public List<Cart> listcart { get; set; }
    public Cart cart { get; set; }
    //Orders
    public List<Orders> listorders { get; set; }
    public Orders order { get; set; }
    //OrderItems
    public List<OrderItems> listOrderItems { get; set; }
    public OrderItems orderitem { get; set; }
    
}