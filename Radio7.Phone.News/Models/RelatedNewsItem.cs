namespace Radio7.Phone.News.Models
{
    public class RelatedNewsItem : NewsItem
    {
        public bool IsComment { get; set; }

        public string CommentTitle { get; set; }

        public NewsItem Article { get; set; }
    }
}
