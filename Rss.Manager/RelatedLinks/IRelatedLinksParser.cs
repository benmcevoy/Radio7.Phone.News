using System.Collections.Generic;

namespace Rss.Manager.RelatedLinks
{
    public interface IRelatedLinksParser
    {
        IEnumerable<RelatedLink> GetRelatedLinks(Item item);
    }
}