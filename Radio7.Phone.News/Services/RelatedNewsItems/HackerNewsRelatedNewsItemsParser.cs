using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Radio7.Portable.StrategyResolver;
using Radio7.Phone.News.Models;
using Radio7.Portable.Rss;

namespace Radio7.Phone.News.Services.RelatedNewsItems
{
    [StrategyFor("news.ycombinator.com")]
    public class HackerNewsRelatedNewsItemsParser : IRelatedNewsItemsParser
    {
        public IEnumerable<RelatedNewsItem> GetRelatedNewsItems(Item item)
        {
            return new List<RelatedNewsItem> { new RelatedNewsItem
                {
                    Url = GetHref(item.Content),
                    Title = "comments",
                    IsComment = true,
                    CommentTitle = item.Title
                } };
        }

        private Uri GetHref(string link)
        {
            const string pattern = @"href=""(.*)""";

            var regex = new Regex(pattern);

            return new Uri(regex.Match(link).Groups[1].Value);
        }

        public bool HasComments()
        {
            return true;
        }

        public RelatedNewsItem GetCommentsUrl(Item item)
        {
            return new RelatedNewsItem
            {
                Url = GetHref(item.Content),
                Title = "comments",
                IsComment = true,
                CommentTitle = item.Title
            };
        }
    }
}
