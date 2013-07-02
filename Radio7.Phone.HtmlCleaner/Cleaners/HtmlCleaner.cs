using System.Linq;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Cleaners
{
    public class HtmlCleaner
    {
        private readonly HtmlDocument _htmlDocument;

        public HtmlCleaner(HtmlDocument htmlDocument)
        {
            _htmlDocument = htmlDocument;
        }

        public HtmlDocument ToHtmlDocument()
        {
            return _htmlDocument;
        }

        public static string Clean(string html)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            return new HtmlCleaner(htmlDocument)
                    .Clean()
                    .ToHtmlDocument()
                    .ConvertToString()
                    .RemoveWhitespace();
        }

        public HtmlCleaner Clean()
        {
            var elementsToRemove = new[] { "script", "noscript", "style", "link", "meta", 
                "iframe", "input", "button", "select", "option", "audio", "canvas", "head",
                "h1","header","footer","aside", "hr","nav","video","object","embed", "#comment" };

            return RemoveElements(elementsToRemove);
        }

        public HtmlCleaner RemoveElements(params string[] elementName)
        {
            _htmlDocument.DocumentNode.Descendants()
                .Where(n => elementName.Contains(n.Name))
                .ToList()
                .ForEach(n => n.Remove());

            return this;
        }

        public HtmlCleaner RemoveAttributes(string attribute)
        {
            var elements = _htmlDocument.DocumentNode.SelectNodes(string.Format("//@{0}", attribute));

            if (elements == null)
            {
                return this;
            }

            foreach (var element in elements)
            {
                try
                {
                    // TODO: try reverse traversal
                    element.Attributes[attribute].Remove();
                }
                catch { }
            }

            return this;
        }
    }
}
