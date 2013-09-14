﻿using System;

namespace Radio7.Portable.Rss
{
    public class Item
    {
        public Item(string id, string raw, string title, string publishedDateTime)
        {
            Id = id;
            Raw = raw;
            Content = raw;
            Title = title;
            PublishedDateTime = publishedDateTime;
        }

        public string Id { get; set; }

        private Uri _url;
        public Uri Url
        {
            get
            {
                if (_url == null)
                {
                    if (!Uri.TryCreate(Id, UriKind.Absolute, out _url))
                    {
                        _url = new Uri("http://google.com/");
                    }
                }
                
                return _url;
            }
        }

        public string Raw { get; set; }

        public string Content { get; private set; }

        public string Title { get; set; }

        public string PublishedDateTime { get; set; }
    }
}