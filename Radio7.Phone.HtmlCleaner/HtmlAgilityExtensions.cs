using System.Diagnostics.CodeAnalysis;
using System.IO;
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
                        IsSuccess = !string.IsNullOrWhiteSpace(result.OuterHtml),
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
                        IsSuccess = !string.IsNullOrWhiteSpace(result.InnerText),
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
                        IsSuccess = !string.IsNullOrWhiteSpace(result.InnerText),
                        Value = result.InnerText
                    };
            }

            return new HtmlResult();
        }

        [SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
        public static string ConvertToUtf8(this HtmlDocument htmlDocument)
        {
            using (var stream = new MemoryStream())
            {
                htmlDocument.Save(stream, new System.Text.UTF8Encoding());
                stream.Position = 0;

                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
