using be_fletchs_news_csharp.Data;
using be_fletchs_news_csharp.Models;
using be_fletchs_news_csharp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace be_fletchs_news_csharp.Repositories
{
    public class TopicRepository : ITopicRepository
    {
        private readonly ApplicationDbContext _context;

        public TopicRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Topic>> GetAllTopicsAsync()
        {
            return await _context.Topics.ToListAsync();
        }

        public async Task<Topic?> GetTopicBySlugAsync(string slug)
        {
            return await _context.Topics.FirstOrDefaultAsync(t => t.Slug == slug);
        }
    }
}
