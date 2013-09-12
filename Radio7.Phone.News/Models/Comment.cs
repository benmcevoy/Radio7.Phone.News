namespace Radio7.Phone.News.Models
{
    public class Comment
    {
        public string Body { get; set; }

        public int Depth { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return string.Format("<div class='comment'>{0}</div>", Body);
        }
    }
}
