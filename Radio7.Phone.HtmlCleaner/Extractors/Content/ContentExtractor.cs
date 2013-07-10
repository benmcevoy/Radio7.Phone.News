using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System;
using Radio7.Phone.HtmlCleaner.Entities;
using Radio7.Phone.HtmlCleaner.Extractors.Title;
using Radio7.Portable.OpenTextSummarizer;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class ContentExtractor : IContentExtractor
    {
        public ExtractedContent Extract(string html, Uri documentUrl)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            var extractedContent = ExtractContent(htmlDocument, documentUrl);

            var title = new TitleExtractor().Extract(html);
            var text = NormalizeText(extractedContent);
            var summary = GetSummary(text);

            return new ExtractedContent
                {
                    Url = documentUrl,
                    Title = title,
                    Html = extractedContent.ConvertToUtf8(),
                    Text = text,
                    Summary = ToText(summary.Sentences),
                    Keywords = summary.Concepts,
                    Domain = GetDomain(documentUrl)
                };
        }

        private string GetDomain(Uri documentUrl)
        {
            var host = documentUrl.Host;

            if (host.StartsWith("www.")) return host.Remove(0, 4);
            if (host.StartsWith("m.")) return host.Remove(0, 2);
            if (host.StartsWith("mobile.")) return host.Remove(0, 7);
            if (host.StartsWith("mobi.")) return host.Remove(0, 5);

            return host;
        }

        private SummarizedDocument GetSummary(string text)
        {
            var summary = Summarizer.Summarize(new SummarizerArguments
                {
                    InputString = text,
                    DisplayPercent = 0,
                    DisplayLines = 2
                });

            return summary;
        }

        private string ToText(IEnumerable<string> sentances)
        {
            var newLine = Environment.NewLine + Environment.NewLine;
            return string.Join(newLine, sentances);
        }

        private string NormalizeText(HtmlDocument htmlDocument)
        {
            Cleaners.HtmlCleaner.With(htmlDocument).RemoveElements("sub");

            var result = new StringBuilder();
            //htmlDocument.DocumentNode.SelectNodes("//text()[normalize-space(.) != '']");
            var innerText = htmlDocument.DocumentNode.InnerText;
            var sentances = innerText.Split(new[] { ".", "?", "!", ";", ".\"", "?\"", "!\"", "|", ".)" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentance in sentances)
            {
                var cleanSentance = sentance.Decode().RemoveDodgyCharacters().RemoveWhitespace();

                if (cleanSentance.StartsWith("("))
                {
                    cleanSentance = cleanSentance.Remove(0, 1).Trim();
                }

                if (cleanSentance.StartsWith(")"))
                {
                    cleanSentance = cleanSentance.Remove(0, 1).Trim();
                }

                if (cleanSentance.Split(' ').Length <= 1) continue;

                result.AppendFormat("{0}{1}{2}{2}", cleanSentance, ".", Environment.NewLine);
            }

            return result.ToString();
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

            Cleaners.HtmlCleaner.With(result).Clean().RemoveAllAttributesExcept("src", "href");

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
                .RemoveXoXo()
                .RemoveEmptyCandidateElements()
                .RebaseUrls()
                .CleanImages();
        }
    }
}

