using System.Collections.Generic;
using System.Linq;

namespace Rss.Manager.RelatedLinks
{
    public class NoRelatedLinksParser : IRelatedLinksParser
    {
        public IEnumerable<RelatedLink> GetRelatedLinks(string html)
        {
            return Enumerable.Empty<RelatedLink>();
        }
    }
}
