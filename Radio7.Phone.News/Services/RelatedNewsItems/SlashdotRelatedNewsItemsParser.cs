using System.Collections.Generic;
using Radio7.Portable.StrategyResolver;
using Radio7.Phone.News.Models;
using Rss.Manager;

namespace Radio7.Phone.News.Services.RelatedNewsItems
{
    [StrategyFor("rss.slashdot.org")]
    public class SlashdotRelatedNewsItemsParser : IRelatedNewsItemsParser
    {
        public IEnumerable<RelatedNewsItem> GetRelatedNewsItems(Item item)
        {
            return new List<RelatedNewsItem> { new RelatedNewsItem
                {
                    Url = item.Url, 
                    Title = "comments", 
                    IsComment = true,
                    CommentTitle = item.Title
                } };
        }
    }
}
