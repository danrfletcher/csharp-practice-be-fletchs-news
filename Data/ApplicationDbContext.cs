using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using be_fletchs_news_csharp.Models;

namespace be_fletchs_news_csharp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
