using AuthAPI.Entities;
using AuthAPI.Models;

namespace AuthAPI.Repositories
{
    public interface IUserRepository
    {
        int Register(User user);
        User Login(Login login);
    }
}
