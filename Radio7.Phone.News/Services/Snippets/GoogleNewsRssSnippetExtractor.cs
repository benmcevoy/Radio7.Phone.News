using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner;
using Radio7.Portable.StrategyResolver;

namespace Radio7.Phone.News.Services.Snippets
{
    [StrategyFor("news.google.com")]
    public class GoogleNewsRssSnippetExtractor : ISnippetExtractor
    {
        public string Extract(string html, int length)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            // TODO: this is pretty fugly
            var elements = htmlDoc.DocumentNode.SelectNodes("//table/tr/td");

            if (elements == null) return Clean(html, length);

            var td = elements.LastOrDefault();

            if (td == null) return Clean(html, length);

            var div = td.SelectNodes("font/div");

            if (div == null) return Clean(html, length);
            if (div.Count == 0) return Clean(html, length);

            var firstDiv = div.Skip(1).FirstOrDefault();

            if (firstDiv == null) return Clean(html, length);

            var fonts = firstDiv.SelectNodes("font");

            if (fonts == null) return Clean(html, length);
            if (fonts.Count == 0) return Clean(html, length);

            var font = fonts.Skip(1).FirstOrDefault();

            return Clean(font == null ? html : font.InnerText, length);
        }

        private static string Clean(string html, int length)
        {
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
