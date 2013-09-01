using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Rss.Manager.RelatedLinks
{
    [RelatedLinkParserFor("news.ycombinator.com")]
    public class HackerNewsRelatedLinksParser : IRelatedLinksParser
    {
        public IEnumerable<RelatedLink> GetRelatedLinks(string html)
        {
            return new List<RelatedLink> { new RelatedLink
                {
                    Link = GetHref(html),
                    Title = "comments"
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
