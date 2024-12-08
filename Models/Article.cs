namespace HW_ASP_9._2.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // Связь с категорией
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty; // Полный текст статьи
    }
}
