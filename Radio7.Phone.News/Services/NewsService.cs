using System;
using System.Linq;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services.RelatedNewsItems;
using Radio7.Phone.News.Services.Snippets;
using Radio7.Portable.Rss;
using Radio7.Portable.StrategyResolver;

namespace Radio7.Phone.News.Services
{
    public class NewsService : INewsService
    {
        private readonly IMessenger _messenger;
        private Feed _feed;
        private readonly StrategyResolver<IRelatedNewsItemsParser> _relatedLinksResolver;
        private readonly StrategyResolver<ISnippetExtractor> _snippetExtractorResolver;

        public NewsService(IMessenger messenger, StrategyResolver<IRelatedNewsItemsParser> relatedLinksResolver, StrategyResolver<ISnippetExtractor> snippetExtractorResolver)
        {
            _messenger = messenger;
            _relatedLinksResolver = relatedLinksResolver;
            _snippetExtractorResolver = snippetExtractorResolver;
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
                Url = i.Url,
                Snippet = _snippetExtractorResolver.Resolve(_feed.FeedUri.Host, new DefaultSnippetExtractor()).Extract(i.Raw, 140),
                Content = i.Content,
                RelatedNewsItems = _relatedLinksResolver.Resolve(_feed.FeedUri.Host, new NoRelatedNewsItemsParser()).GetRelatedNewsItems(i).ToList()
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
