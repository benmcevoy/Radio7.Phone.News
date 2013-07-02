using System.Linq;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Extractors.Snippet
{
    public class GoogleNewsRssSnippetExtractor : ISnippetExtractor
    {
        public string Extract(string html, int length)
        {
            try
            {
                var htmlDoc = new HtmlDocument();

                htmlDoc.LoadHtml(html);

                var td = htmlDoc.DocumentNode.SelectNodes("//table/tr/td").LastOrDefault();

                if (td != null)
                {
                    var div = td.SelectNodes("font/div").Skip(1).FirstOrDefault();

                    if (div != null)
                        div = div.SelectNodes("font").Skip(1).FirstOrDefault();

                    if (div != null)
                        html = div.InnerText;
                }
            }
            catch
            {
            }

            return html.StripTags()
                .Decode()
                .RemoveDodgyCharacters()
                .RemoveWhitespace()
                .TrimWithEllipsis(length);
        }

        public string Extract(string html)
        {
            return Extract(html, int.MaxValue);
        }
    }
}
