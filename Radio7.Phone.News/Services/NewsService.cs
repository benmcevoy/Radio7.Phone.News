using System;
using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Infrastructure;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services.RelatedNewsItems;
using Radio7.Phone.News.Services.Snippets;
using Radio7.Portable.StrategyResolver;
using Radio7.Portable.Rss;

namespace Radio7.Phone.News.Services
{
    public class NewsService : INewsService
    {
        private readonly IMessenger _messenger;
        private Feed _feed;
        private readonly StrategyResolver<IRelatedNewsItemsParser> _relatedLinksResolver;
        private readonly StrategyResolver<ISnippetExtractor> _snippetExtractorResolver;
        private readonly ICacheProvider _cacheProvider;
        private static readonly DefaultSnippetExtractor DefaultSnippetExtractor = new DefaultSnippetExtractor();
        private static readonly NoRelatedNewsItemsParser DefaultRelatedNewsItemsParser = new NoRelatedNewsItemsParser();

        public NewsService(IMessenger messenger, StrategyResolver<IRelatedNewsItemsParser> relatedLinksResolver,
            StrategyResolver<ISnippetExtractor> snippetExtractorResolver, ICacheProvider cacheProvider)
        {
            _messenger = messenger;
            _relatedLinksResolver = relatedLinksResolver;
            _snippetExtractorResolver = snippetExtractorResolver;
            _cacheProvider = cacheProvider;
        }

        // TODO: use aysnc await, no more events
        public void BeginGetNews(Uri url)
        {
            _messenger.Send(ProgressMessage.EmptyMessage);

            var newsItems = _cacheProvider.Get<IEnumerable<NewsItem>>(url.ToString());

            if (newsItems != null)
            {
                RaiseGetNewsComplete(newsItems);
                return;
            }

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
                Snippet = _snippetExtractorResolver.Resolve(_feed.FeedUri.Host, DefaultSnippetExtractor).Extract(i.Raw, 140),
                Content = i.Content,
                HasComments = _relatedLinksResolver.Resolve(_feed.FeedUri.Host, DefaultRelatedNewsItemsParser).HasComments(),
                CommentsItem = _relatedLinksResolver.Resolve(_feed.FeedUri.Host, DefaultRelatedNewsItemsParser).GetCommentsUrl(i),
                RelatedNewsItems = _relatedLinksResolver.Resolve(_feed.FeedUri.Host, DefaultRelatedNewsItemsParser).GetRelatedNewsItems(i).ToList()
            }).ToList();

            foreach (var newsItem in newsItems.Where(i => i.CommentsItem != null))
            {
                newsItem.CommentsItem.Article = newsItem;
            }

            _cacheProvider.Set(_feed.FeedUri.ToString(), newsItems);

            RaiseGetNewsComplete(newsItems);
        }

        private void RaiseGetNewsComplete(IEnumerable<NewsItem> newsItems)
        {
            if (GetNewsComplete != null)
            {
                GetNewsComplete(this, new GetNewsCompleteEventArgs(newsItems));
            }

            _messenger.Send(new ProgressMessage());
        }

        public event EventHandler<GetNewsCompleteEventArgs> GetNewsComplete;
    }
}
