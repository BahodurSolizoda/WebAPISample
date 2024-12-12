using Microsoft.AspNetCore.Mvc;
using WebAPI1.Domain.Models;


namespace WebAPI1.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly List<User> users = new();

    [HttpGet]
    public List<User> GetUsers()
    {
        return users;
    }

    [HttpPost]
    public string CreateUser(User user)
    { 
        var id = users.Count + 1;
        users.Add(user);
        return id.ToString();
    }

    [HttpPut]
    public string Put(int id, User updatedUser)
    {
        if (id != updatedUser.UserId)
            return "User Id does not match";
        User existingUser = users.FirstOrDefault(u => u.UserId == id);
        existingUser.UserId = updatedUser.UserId;
        existingUser.Username = updatedUser.Username;
        existingUser.DateOfBirth = updatedUser.DateOfBirth;
        existingUser.Email = updatedUser.Email;
        existingUser.Address = updatedUser.Address;
        return "User updated";
    }

    [HttpDelete]
    public string Delete(int id)
    {
       var user = users.FirstOrDefault(u => u.UserId == id);
       users.Remove(user);
       return "User deleted";
    }
}