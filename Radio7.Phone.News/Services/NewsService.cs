using System;
using System.Linq;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Models;
using Rss.Manager;

namespace Radio7.Phone.News.Services
{
    public class NewsService : INewsService
    {
        private readonly IMessenger _messenger;
        private Feed _feed;

        public NewsService(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public void BeginGetNews(Uri url)
        {
            _messenger.Send(new ProgressMessage(" "));

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

            if (GetNewsComplete != null)
            {
                GetNewsComplete(this, new GetNewsCompleteEventArgs(newsItems));
            }

            _messenger.Send(new ProgressMessage());
        }

        public event EventHandler<GetNewsCompleteEventArgs> GetNewsComplete;
    }
}
