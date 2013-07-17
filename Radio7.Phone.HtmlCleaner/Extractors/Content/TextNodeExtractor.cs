using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner.Entities;
using Radio7.Phone.HtmlCleaner.Extractors.Title;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class TextNodeExtractor : IContentExtractor
    {
        public ExtractedContent Extract(string html, Uri documentUrl)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            var extractedContent = ExtractContent(htmlDocument, documentUrl);
            var title = new TitleExtractor().Extract(html);

            return new ExtractedContent
            {
                Url = documentUrl,
                Title = title,
                Html = extractedContent.ConvertToUtf8()
            };
        }

        private HtmlDocument ExtractContent(HtmlDocument htmlDocument, Uri documentUrl)
        {
            var scorer = new TextNodeScorer();
            var candidates = scorer.Score(htmlDocument).ToArray();
            var topCandidate = candidates.OrderByDescending(c => c.Score).FirstOrDefault();
            var result = new HtmlDocument();
            var container = result.CreateElement("div");

            if (topCandidate != null) container.AppendChild(topCandidate.HtmlNode);

            result.DocumentNode.AppendChild(container);

            Cleaners.HtmlCleaner.With(result).Clean().RemoveAllAttributesExcept("src", "href");

            return result;
        }
    }
}
