using AuthAPI.Entities;

namespace AuthAPI.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
