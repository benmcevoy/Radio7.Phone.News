namespace Radio7.Phone.HtmlCleaner.Extractors.Snippet
{
    public interface ISnippetExtractor
    {
        string Extract(string html);

        string Extract(string html, int length);
    }
}
