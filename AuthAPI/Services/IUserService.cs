using AuthAPI.Entities;
using AuthAPI.Models;

namespace AuthAPI.Services
{
    public interface IUserService
    {
        string Register(User user);
        User Login(Login login);
    }
}
