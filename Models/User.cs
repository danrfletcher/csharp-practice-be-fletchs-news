using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace be_fletchs_news_csharp.Models
{
    public class User
    {
        [Key]
        [Column("username")]
        public string Username { get; set; } = string.Empty;
        [Column("name")]
        public string Name { get; set; } = string.Empty;
        [Column("avatar_url")]
        public string AvatarUrl { get; set; } = string.Empty;
        [Column("password")]
        public string Password { get; set; } = string.Empty;
    }
}
