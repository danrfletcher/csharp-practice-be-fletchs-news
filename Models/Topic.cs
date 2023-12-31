using System.ComponentModel.DataAnnotations.Schema;

namespace be_fletchs_news_csharp.Models
{
    public class Topic
    {
        [Column("slug")]
        public string Slug { get; set; } = string.Empty;
        [Column("description")]
        public string Description { get; set; } = string.Empty;
    }
}
