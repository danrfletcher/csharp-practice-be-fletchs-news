using System.Collections.Generic;
using System.Threading.Tasks;
using be_fletchs_news_csharp.Models;

namespace be_fletchs_news_csharp.Repositories.Interfaces
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetAllArticlesAsync();
        Task<Article> GetArticleByIdAsync(int id);
        Task<Article> CreateArticleAsync(Article article);
        Task UpdateArticleAsync(Article article);
        Task DeleteArticleAsync(int id);
    }
}
