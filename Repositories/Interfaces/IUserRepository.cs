using be_fletchs_news_csharp.Models;

namespace be_fletchs_news_csharp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(string username);
    }
}
