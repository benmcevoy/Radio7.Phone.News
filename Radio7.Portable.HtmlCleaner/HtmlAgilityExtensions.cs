using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner
{
    public static class HtmlAgilityExtensions
    {
        public static HtmlResult TryGetHtmlByElementId(this HtmlDocument htmlDocument, string id)
        {
            var result = htmlDocument.GetElementbyId(id);

            if (result != null)
            {
                return new HtmlResult
                    {
                        IsSuccess = true,
                        Value = result.OuterHtml
                    };
            }

            return new HtmlResult();
        }

        public static HtmlResult TryGetInnerTextByElementId(this HtmlDocument htmlDocument, string id)
        {
            var result = htmlDocument.GetElementbyId(id);

            if (result != null)
            {
                return new HtmlResult
                    {
                        IsSuccess = true,
                        Value = result.InnerText
                    };
            }

            return new HtmlResult();
        }

        public static HtmlResult TryGetInnerTextByTagName(this HtmlDocument htmlDocument, string tagName)
        {
            var result = htmlDocument.DocumentNode.SelectSingleNode("//" + tagName);

            if (result != null)
            {
                return new HtmlResult
                    {
                        IsSuccess = true,
                        Value = result.InnerText
                    };
            }

            return new HtmlResult();
        }

        public static string ConvertToString(this HtmlDocument htmlDocument)
        {
            using (var writer = new StringWriter())
            {
                htmlDocument.Save(writer);
                return writer.ToString();
            }
        }
    }
}
