using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner;

namespace Rss.Manager
{
    public class RelatedLink
    {
        public string Title { get; set; }
        public string Link { get; set; }
    }

    public static class RelatedLinksParser
    {
        public static IEnumerable<RelatedLink> GetRelatedLinks(string html)
        {
            var results = new List<RelatedLink>();

            try
            {
                var htmlDoc = new HtmlDocument();

                htmlDoc.LoadHtml(html);

                var td = htmlDoc.DocumentNode.SelectNodes("//table/tr/td").LastOrDefault();

                if (td != null)
                {
                    var div = td.SelectNodes("font/div").Skip(1).FirstOrDefault();

                    if (div != null)
                    {
                        var links = div.SelectNodes("font/a");

                        if (links != null )
                        {
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
                    }
                }
            }
            catch
            {
            }

            return results;
        }
    }
}
