using System.Collections.Generic;
using Radio7.Phone.News.Models;
using Radio7.Portable.Rss;

namespace Radio7.Phone.News.Services.RelatedNewsItems
{
    public interface IRelatedNewsItemsParser
    {
        IEnumerable<RelatedNewsItem> GetRelatedNewsItems(Item item);
    }
}