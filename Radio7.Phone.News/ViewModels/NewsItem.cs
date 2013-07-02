﻿using System;
using System.Collections.Generic;

namespace Radio7.Phone.News.ViewModels
{
    public class NewsItem
    {
        public string Title { get; set; }

        public Uri Url { get; set; }

        public string Snippet { get; set; }

        public List<RelatedNewsItem> RelatedNewsItems { get; set; }
    }
}
