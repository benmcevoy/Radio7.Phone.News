using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Radio7.Portable.Rss;
using Radio7.Portable.StrategyResolver;
using Radio7.Phone.News.Models;

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
                    IsComment = true
                } };
        }

        private Uri GetHref(string link)
        {
            const string pattern = @"href=""(.*)""";

            var regex = new Regex(pattern);

            return new Uri(regex.Match(link).Groups[1].Value);
        }
    }
}
