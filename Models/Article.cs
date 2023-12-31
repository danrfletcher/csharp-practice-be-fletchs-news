using System.ComponentModel.DataAnnotations.Schema;

namespace be_fletchs_news_csharp.Models
{
    public class Article
    {
        [Column("article_id")]
        public int ArticleId { get; set; }
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Column("topic")]
        public string Topic { get; set; } = string.Empty;
        [Column("author")]
        public string Author { get; set; } = string.Empty;
        [Column("body")]
        public string Body { get; set; } = string.Empty;
        [Column("created_at")]
        public string CreatedAt { get; set; } = string.Empty;
        [Column("votes")]
        public int Votes { get; set; }
        [Column("article_img_url")]
        public string ArticleImgUrl { get; set; } = string.Empty;

    }
}
