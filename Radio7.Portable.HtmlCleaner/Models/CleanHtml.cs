﻿using System;

namespace Radio7.Phone.HtmlCleaner.Models
{
    public class CleanHtml
    {
        public CleanHtml(Uri url, string title, string content)
        {
            Url = url;
            Title = title;
            Content = content;
        }

        public Uri Url { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
