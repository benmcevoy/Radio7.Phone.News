using System.Collections.Generic;
using Radio7.Portable.StrategyResolver;

namespace Rss.Manager.RelatedLinks
{
    [StrategyFor("rss.slashdot.org")]
    public class SlashdotRelatedLinksParser : IRelatedLinksParser
    {
        public IEnumerable<RelatedLink> GetRelatedLinks(Item item)
        {
            return new List<RelatedLink> { new RelatedLink { Link = item.Id, Title = "comments", IsComment = true } };
        }
    }
}
