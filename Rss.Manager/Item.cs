﻿using System;
using Radio7.Phone.HtmlCleaner.Cleaners;

namespace Rss.Manager
{
    public class Item
    {
        public Item(string id, string raw, string title, string publishedDateTime)
        {
            Id = id;
            Raw = raw;
            Content = HtmlCleaner.Clean(raw);
            Title = title;
            PublishedDateTime = publishedDateTime;
        }

        public string Id { get; set; }

        public Uri Url
        {
            get { return new Uri(Id); }
        }

        public string Raw { get; set; }

        public string Content { get; private set; }

        public string Title { get; set; }

        public string PublishedDateTime { get; set; }
    }
}