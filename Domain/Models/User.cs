namespace WebAPI1.Domain.Models;

public class User
{
    public int  UserId { get; set; }
    public string? Username { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
}