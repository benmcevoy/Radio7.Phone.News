using System.Linq;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Cleaners
{
    public class HtmlCleaner : IHtmlCleaner
    {
        public string Clean(string html)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            return Clean(htmlDocument)
                .ConvertToString()
                .RemoveWhitespace();
        }

        public HtmlDocument Clean(HtmlDocument htmlDocument)
        {
            // TODO: update for HTML5
            htmlDocument.DocumentNode.Descendants()
                .Where(n =>
                    n.Name == "script" ||
                    n.Name == "noscript" ||
                    n.Name == "style" ||
                    n.Name == "link" ||
                    n.Name == "meta" ||
                    n.Name == "iframe" ||
                    n.Name == "input" ||
                    n.Name == "select" ||
                    n.Name == "button" ||
                    n.Name == "option" ||
                    n.Name == "audio" ||
                    n.Name == "canvas" ||
                    n.Name == "head" ||
                    n.Name == "h1" ||
                    n.Name == "header" ||
                    n.Name == "footer" ||
                    n.Name == "aside" ||
                    n.Name == "hr" ||
                    n.Name == "nav" ||
                    // TODO: might be video
                    n.Name == "video" ||
                    // TODO: might be video
                    n.Name == "object" ||
                    // TODO: might be video
                    n.Name == "embed" ||
                    n.Name == "#comment")
                .ToList()
                .ForEach(n => n.Remove());

            //cleaner.Clean(htmlDocument, "head");
            //cleaner.Clean(htmlDocument, "h1");
            //cleaner.Clean(htmlDocument, "header");
            //cleaner.Clean(htmlDocument, "footer");
            //cleaner.Clean(htmlDocument, "aside");
            //cleaner.Clean(htmlDocument, "hr");
            //cleaner.Clean(htmlDocument, "nav");

            return htmlDocument;
        }

        public HtmlDocument Clean(HtmlDocument htmlDocument, string elementName)
        {
            htmlDocument.DocumentNode.Descendants()
                .Where(n => n.Name == elementName)
                .ToList()
                .ForEach(n => n.Remove());

            return htmlDocument;
        }
    }
}
