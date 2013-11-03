using System;
using System.Collections.Generic;

namespace Radio7.Phone.News.Models
{
    public class NewsItem
    {
        public string Title { get; set; }

        public Uri Url { get; set; }

        public string Snippet { get; set; }

        public string Content { get; set; }

        public bool HasComments { get; set; }

        public RelatedNewsItem CommentsItem { get; set; }

        public List<RelatedNewsItem> RelatedNewsItems { get; set; }
    }
}
