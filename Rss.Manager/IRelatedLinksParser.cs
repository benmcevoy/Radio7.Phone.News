using System.Collections.Generic;

namespace Rss.Manager
{
    public interface IRelatedLinksParser
    {
        IEnumerable<RelatedLink> GetRelatedLinks(string html);
    }
}