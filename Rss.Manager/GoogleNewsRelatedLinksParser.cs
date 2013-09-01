using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner;

namespace Rss.Manager
{
    public class GoogleNewsRelatedLinksParser : IRelatedLinksParser
    {
        public IEnumerable<RelatedLink> GetRelatedLinks(string html)
        {
            var results = new List<RelatedLink>();

            try
            {
                var htmlDoc = new HtmlDocument();

                htmlDoc.LoadHtml(html);

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
                    var result = new RelatedLink
                        {
                            Title = relatedLink.InnerText.Decode().StripTags(),
                            Link = relatedLink.GetAttributeValue("href", "")
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
    }
}
