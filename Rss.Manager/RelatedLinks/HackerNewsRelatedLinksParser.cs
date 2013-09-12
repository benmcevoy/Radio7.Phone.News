using System.Collections.Generic;
using System.Text.RegularExpressions;
using Radio7.Portable.StrategyResolver;

namespace Rss.Manager.RelatedLinks
{
    [StrategyFor("news.ycombinator.com")]
    public class HackerNewsRelatedLinksParser : IRelatedLinksParser
    {
        public IEnumerable<RelatedLink> GetRelatedLinks(Item item)
        {
            return new List<RelatedLink> { new RelatedLink
                {
                    Link = GetHref(item.Content),
                    Title = "comments",
                    IsComment = true
                } };
        }

        private string GetHref(string link)
        {
            const string pattern = @"href=""(.*)""";

            var regex = new Regex(pattern);

            return regex.Match(link).Groups[1].Value;
        }
    }
}
