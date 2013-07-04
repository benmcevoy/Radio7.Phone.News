using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Radio7.Phone.News.Data;
using Radio7.Phone.News.Infrastructure;
using Radio7.Phone.News.Models;
using Rss.Manager;

namespace Radio7.Phone.News.Services
{
    public class NewsService : INewsService
    {
        private Feed _feed;
     
        public void BeginGetNews(Uri url)
        {
            _feed = new Feed(url);
            _feed.FeedLoaded += OnFeedLoaded;
            _feed.GetItemsFromWeb();
        }

        private void OnFeedLoaded(object sender, EventArgs e)
        {
            var newsItems = _feed.Items.Select(i => new NewsItem
            {
                Title = i.Title,
                Url = new Uri(i.Id, UriKind.Absolute),
                Snippet = i.Snippet,
                RelatedNewsItems = RelatedLinksParser.GetRelatedLinks(i.Content).Select(r => new RelatedNewsItem
                {
                    Title = r.Title,
                    Url = new Uri(r.Link, UriKind.Absolute)
                }).ToList()
            });

            if(GetNewsComplete != null)
            {
                GetNewsComplete(this, new GetNewsCompleteEventArgs(newsItems));
            }
        }

        public event EventHandler<GetNewsCompleteEventArgs> GetNewsComplete;
    }
}
