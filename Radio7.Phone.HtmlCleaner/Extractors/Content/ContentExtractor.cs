using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner.Entities;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class ContentExtractor : IContentExtractor
    {
        public string Extract(string html)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            var extractedContent = ExtractContent(htmlDocument);

            return extractedContent.ConvertToString().RemoveWhitespace();
        }

        private HtmlDocument ExtractContent(HtmlDocument htmlDocument)
        {
            CleanAndNormalize(htmlDocument);

            var scorer = new Scorer();
            var candidates = scorer.Score(htmlDocument).ToArray();

            ScaleCandidateScoresByLinkDensity(candidates);

            var topCandidate = candidates.OrderByDescending(c => c.Score).FirstOrDefault();
            var result = new HtmlDocument();
            var container = result.CreateElement("div");

            if (topCandidate != null) container.AppendChild(topCandidate.HtmlNode);

            result.DocumentNode.AppendChild(container);

            new Cleaners.HtmlCleaner(result)
                .RemoveAttributes("style")
                .RemoveAttributes("class")
                .RemoveAttributes("id")
                .RemoveAttributes("width")
                .RemoveAttributes("height");

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

        private void ScaleCandidateScoresByLinkDensity(IEnumerable<CandidateNode> candidateNodes)
        {
            foreach (var candidateNode in candidateNodes)
            {
                var linkDensity = GetLinkDensity(candidateNode.HtmlNode);
                candidateNode.Score = candidateNode.Score * (1 - linkDensity);
            }
        }

        private double GetLinkDensity(HtmlNode htmlNode)
        {
            var links = htmlNode.SelectNodes("a");

            if (links == null) return 0D;

            var linkLength = (double)links.Sum(l => l.InnerText.Length);
            var textLength = (double)htmlNode.InnerText.Length;

            return linkLength / textLength;
        }

        private void CleanAndNormalize(HtmlDocument htmlDocument)
        {
            new Cleaners.HtmlCleaner(htmlDocument).Clean();

            new Normalizer(htmlDocument)
                .FindBestCandidateFrame()
                .EnsureBodyElement()
                .RemoveBoilerPlateCandidates()
                .ReplaceFonts()
                .ReplaceBrCandidates()
                .RemoveEmptyCandidateElements()
                .CleanImages();
        }
    }
}

