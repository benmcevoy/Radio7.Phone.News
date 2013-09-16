using System.Collections.Generic;
using System.Linq;
using Radio7.Phone.News.Models;
using Rss.Manager;

namespace Radio7.Phone.News.Services.RelatedNewsItems
{
    public class NoRelatedNewsItemsParser : IRelatedNewsItemsParser
    {
        public IEnumerable<RelatedNewsItem> GetRelatedNewsItems(Item item)
        {
            return Enumerable.Empty<RelatedNewsItem>();
        }
    }
}
