using System.Linq;
using HtmlAgilityPack;
using System;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class ContentExtractor : IContentExtractor
    {
        public string Extract(string html, Uri documentUrl)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            var extractedContent = ExtractContent(htmlDocument, documentUrl);

            return extractedContent.ConvertToUtf8();
        }

        private HtmlDocument ExtractContent(HtmlDocument htmlDocument, Uri documentUrl)
        {
            // pre-process
            CleanAndNormalize(htmlDocument, documentUrl);

            // score
            var scorer = new Scorer();
            var candidates = scorer.Score(htmlDocument).ToArray();

            // scoring startegy should be passed in somehow
            // var rawscores = candidates.OrderByDescending(c => c.RawScore);
            //foreach (var rawscore in candidates)
            //{
            //    if (rawscore.RawScore > 2)
            //    {
            //        Debug.WriteLine("{2}", rawscore.Score, rawscore.RawScore,
            //                        rawscore.HtmlNode.InnerText);
            //    }
            //}

            // post-process
            var topCandidate = candidates.OrderByDescending(c => c.Score).FirstOrDefault();
            var result = new HtmlDocument();
            var container = result.CreateElement("div");

            if (topCandidate != null) container.AppendChild(topCandidate.HtmlNode);

            result.DocumentNode.AppendChild(container);

            Cleaners.HtmlCleaner.With(result).RemoveAllAttributesExcept("src", "href");

            return result;
            // select top candidate
            // process top candidate siblings
            //  assign score bonus if top.class == sibling class (20% bonus)
            //  if sibling score > threshold ( Math.max(10, topCandidate.readability.contentScore * 0.2); then append
            //  if sibling is p with more than 80 characters and low link density (<.25) then append
            //  if append
            //      if not a div or p then convert to div
            //  remove classnames, id's 

            // if the final content is less than 250 characters then 
            // retry with differnet flags,
            // e.g. allow unlikelys, add class weights, less cleaning
            // a SIEVE

            // we need a clone of the original doc for this to work

            //return htmlDocument;
        }

        private void CleanAndNormalize(HtmlDocument htmlDocument, Uri documentUrl)
        {
            Cleaners.HtmlCleaner.With(htmlDocument).Clean();

            Normalizer.With(htmlDocument, documentUrl)
                .FindBestCandidateFrame()
                .EnsureBodyElement()
                .RemoveBoilerPlateCandidates()
                .ReplaceFonts()
                .RemoveEmptyCandidateElements()
                .RebaseUrls()
                .CleanImages();
        }
    }
}

