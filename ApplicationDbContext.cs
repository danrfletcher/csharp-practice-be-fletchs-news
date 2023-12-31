using Microsoft.EntityFrameworkCore;

namespace be_fletchs_news_csharp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
