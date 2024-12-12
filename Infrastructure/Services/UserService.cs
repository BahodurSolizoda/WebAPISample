using WebAPI1.Domain.Models;
using WebAPI1.Infrastructure.Interfaces;

namespace WebAPI1.Infrastructure.Services;

public class UserService:IUser
{
    private readonly List<User> iusers = new();

    public bool InsertUser(int userId)
    {
        if (iusers.Any(e => e.UserId == userId)) return false;
        iusers.Add(new User(){ UserId = userId });
        return true;
    }

    public List<User> GetUsers()
    {
        return iusers;
    }

    public User GetUserById(int id)
    {
        return iusers.FirstOrDefault(u => u.UserId == id);
    }

    public bool UpdateUser(User user)
    {
        var existUser = iusers.FirstOrDefault(u => u.UserId == user.UserId);
        if (existUser == null) return false;
        iusers.Add(user);
        return true;
    }

    public bool DeleteUser(int id)
    {
        var existUser = iusers.FirstOrDefault(u => u.UserId == id);
        if (existUser == null) return false;
        iusers.Remove(existUser);
        return true;
    }
}