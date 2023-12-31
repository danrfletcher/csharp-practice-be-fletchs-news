using be_fletchs_news_csharp.Models;

namespace be_fletchs_news_csharp.Repositories.Interfaces
{
    public interface ITopicRepository
    {
        Task<IEnumerable<Topic>> GetAllTopicsAsync();
        Task<Topic?> GetTopicBySlugAsync(string slug);
    }
}
