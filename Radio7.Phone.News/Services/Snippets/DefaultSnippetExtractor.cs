using Radio7.Phone.HtmlCleaner;

namespace Radio7.Phone.News.Services.Snippets
{
    public class DefaultSnippetExtractor : ISnippetExtractor
    {
        public string Extract(string html, int length)
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
