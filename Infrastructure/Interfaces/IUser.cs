using WebAPI1.Domain.Models;

namespace WebAPI1.Infrastructure.Interfaces;

public interface IUser
{
    bool InsertUser(int userId);
    List<User> GetUsers();
    User GetUserById(int id);
    bool UpdateUser(User user);
    bool DeleteUser(int id);
}