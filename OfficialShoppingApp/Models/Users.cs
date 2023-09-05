using System.Runtime.InteropServices.JavaScript;

namespace OfficialShoppingApp.Models;

public class Users
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateOnly Dob { get; set; }
    public string? Address { get; set; }
    public decimal Balance { get; set; }
    public string Type { get; set; }
    public int Status { get; set; }
    public DateTime CreatedOn { get; set; }
    
}