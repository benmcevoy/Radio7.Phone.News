using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner;
using Radio7.Portable.StrategyResolver;
using Radio7.Phone.News.Models;
using Radio7.Portable.Rss;

namespace Radio7.Phone.News.Services.RelatedNewsItems
{
    [StrategyFor("news.google.com")]
    public class GoogleNewsRelatedNewsItemsParser : IRelatedNewsItemsParser
    {
        public IEnumerable<RelatedNewsItem> GetRelatedNewsItems(Item item)
        {
            var results = new List<RelatedNewsItem>();

            try
            {
                var htmlDoc = new HtmlDocument();

                htmlDoc.LoadHtml(item.Content);

                var elements = htmlDoc.DocumentNode.SelectNodes("//table/tr/td");

                if (elements == null) return results;

                var td = elements.LastOrDefault();

                if (td == null) return results;

                var div = td.SelectNodes("font/div");

                if (div == null) return results;
                if (div.Count == 0) return results;

                var links1 = div.Skip(1).FirstOrDefault();

                if (links1 == null) return results;

                var links = links1.SelectNodes("font/a");

                if (links == null) return results;

                foreach (var relatedLink in links)
                {
                    var result = new RelatedNewsItem
                        {
                            Title = relatedLink.InnerText.Decode().StripTags(),
                            Url = new Uri(relatedLink.GetAttributeValue("href", ""))
                        };

                    results.Add(result);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return results;
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
