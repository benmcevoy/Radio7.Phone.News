namespace Radio7.Phone.HtmlCleaner.Extractors.Snippet
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
