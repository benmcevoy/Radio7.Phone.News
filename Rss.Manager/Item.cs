using System.Collections.Generic;
using Radio7.Phone.HtmlCleaner.Cleaners;
using Radio7.Phone.HtmlCleaner.Extractors.Snippet;
using Rss.Manager.RelatedLinks;

namespace Rss.Manager
{
    public class Item
    {
        private readonly ISnippetExtractor _snippetExtractor;

        public Item()
        {
            _snippetExtractor = new GoogleNewsRssSnippetExtractor();
        }

        public Item(string id, string raw, string title, string publishedDateTime)
            :this()
        {
            Id = id;
            Raw = raw;
            Content = HtmlCleaner.Clean(raw);
            Snippet = _snippetExtractor.Extract(raw, 140);
            Title = title;
            PublishedDateTime = publishedDateTime;
        }

        public string Id { get; set; }

        public string Raw { get; set; }

        public string Content { get; private set; }

        public string Snippet { get; private set; }

        public string Title { get; set; }

        public string PublishedDateTime { get; set; }

        public IEnumerable<RelatedLink> RelatedLinks { get; set; }
    }
}