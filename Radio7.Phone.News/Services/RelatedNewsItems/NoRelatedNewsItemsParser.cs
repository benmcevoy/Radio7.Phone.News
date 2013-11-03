using System;
using System.Collections.Generic;
using System.Linq;
using Radio7.Phone.News.Models;
using Radio7.Portable.Rss;

namespace Radio7.Phone.News.Services.RelatedNewsItems
{
    public class NoRelatedNewsItemsParser : IRelatedNewsItemsParser
    {
        public IEnumerable<RelatedNewsItem> GetRelatedNewsItems(Item item)
        {
            return Enumerable.Empty<RelatedNewsItem>();
        }

        public bool HasComments()
        {
            return false;
        }

        public RelatedNewsItem GetCommentsUrl(Item item)
        {
            return null;
        }
    }
}
