using MyApi.Models;

namespace MyApi.Services
{
    public interface IUserService
    {
        Task<User?> RegisterAsync(string username, string email, string password);
        Task<User?> GetByEmailAsync(string email);
        Task<User?> GetByUsernameAsync(string username);
        Task<User?> ValidateUserAsync(string usernameOrEmail, string password);
    }
}
