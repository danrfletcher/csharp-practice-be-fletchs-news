using System.ComponentModel.DataAnnotations.Schema;

namespace be_fletchs_news_csharp.Models
{
    public class Comment
    {
        [Column("comment_id")]
        public int CommentId { get; set; }
        [Column("body")]
        public string Body { get; set; } = string.Empty;
        [Column("article_id")]
        public int ArticleId { get; set; }
        [Column("author")]
        public string Author { get; set; } = string.Empty;
        [Column("votes")]
        public int Votes { get; set; }
        [Column("created_at")]
        public string CreatedAt { get; set; } = string.Empty;
    }
}
