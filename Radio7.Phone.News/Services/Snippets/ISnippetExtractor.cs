namespace Radio7.Phone.News.Services.Snippets
{
    public interface ISnippetExtractor
    {
        string Extract(string html);

        string Extract(string html, int length);
    }
}
