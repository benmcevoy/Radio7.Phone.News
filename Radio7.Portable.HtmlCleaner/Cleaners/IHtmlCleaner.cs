
using HtmlAgilityPack;
namespace Radio7.Phone.HtmlCleaner.Cleaners
{
    public interface IHtmlCleaner
    {
        string Clean(string html);

        HtmlDocument Clean(HtmlDocument htmlDocument);

        HtmlDocument Clean(HtmlDocument htmlDocument, string elementName);
    }
}
