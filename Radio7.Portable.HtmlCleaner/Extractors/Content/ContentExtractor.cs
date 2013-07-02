using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using Radio7.Phone.HtmlCleaner.Models;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class ContentExtractor : IContentExtractor
    {
        private readonly List<CandidateNode> _candidateNodes = new List<CandidateNode>(64);

        private static readonly Regex UnlikeyCandidateRegex =
            new Regex(
                @"combx|comment|community|disqus|extra|foot|header|menu|remark|rss|shoutbox|sidebar|sponsor|ad-break|agegate|pagination|pager|popup|tweet|twitter|hidden|aside|advert|overlay|nav|sub-nav|share|toolbar|playlist|addthis|social",
                RegexOptions.IgnoreCase);


        private static readonly Regex PositiveCandidateRegex =
            new Regex(
                @"article|body|content|entry|hentry|main|page|pagination|post|blog|story|articleBody",
                RegexOptions.IgnoreCase);

        private static readonly Regex NegativeCandidateRegex =
            new Regex(
                @"combx|comment|com-|contact|foot|footer|footnote|masthead|media|meta|outbrain|promo|related|scroll|shoutbox|sidebar|sponsor|shopping|tags|tool|widget|metadata|overlay|video|nav",
                RegexOptions.IgnoreCase);

        private static readonly Regex DivToPElements =
            new Regex(
                @"/<(a|blockquote|dl|div|img|ol|p|pre|table|ul)",
                RegexOptions.IgnoreCase);

        public string Extract(string html)
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            Normalize(htmlDocument);

            htmlDocument = ExtractContent(htmlDocument);

            RemoveAttribute(htmlDocument, "__score");
            RemoveAttribute(htmlDocument, "__id");
            RemoveAttribute(htmlDocument, "style");
            RemoveAttribute(htmlDocument, "class");
            RemoveAttribute(htmlDocument, "id");

            return htmlDocument.ConvertToString().RemoveWhitespace();
        }

        

        private void UpsertCandidateNode(HtmlNode htmlNode)
        {
            var score = Convert.ToDouble(htmlNode.GetAttributeValue("__score", "0.0"));
            var id = Guid.Parse(htmlNode.GetAttributeValue("__id", Guid.Empty.ToString("D")));

            var candidateNode = new CandidateNode
                {
                    HtmlNode = htmlNode,
                    Score = score,
                    Id = id
                };

            if (_candidateNodes.Any(c => c.Id == id))
            {
                _candidateNodes.First(c => c.Id == id).Score = score;
                return;
            }

            _candidateNodes.Add(candidateNode);
        }

        private HtmlDocument ExtractContent(HtmlDocument htmlDocument)
        {
            var nodesToScore = GetNodesToScore(htmlDocument);

            foreach (var htmlNode in nodesToScore)
            {
                if (htmlNode.ParentNode == null) continue;

                EnsureCandidateScoreAttributes(htmlNode.ParentNode);

                var score = 0D;

                score++;
                score += GetContentCommaCountScore(htmlNode);
                score += GetElementWeightScore(htmlNode);
                score += GetClassWeightScore(htmlNode);
                score += GetContentLengthScore(htmlNode);
                score += GetContentDensityScore(htmlNode);

                // add score to parent
                AddHtmlNodeScoreAttribute(htmlNode.ParentNode, score);

                UpsertCandidateNode(htmlNode.ParentNode);

                if (htmlNode.ParentNode.ParentNode == null) continue;

                EnsureCandidateScoreAttributes(htmlNode.ParentNode.ParentNode);

                // add half to grandparent
                AddHtmlNodeScoreAttribute(htmlNode.ParentNode.ParentNode, score / 2D);

                UpsertCandidateNode(htmlNode.ParentNode.ParentNode);
            }

            ScaleCandidateScoresByLinkDensity(_candidateNodes);

            var topCandidate = _candidateNodes.OrderByDescending(c => c.Score).FirstOrDefault();
            var result = new HtmlDocument();
            var container = result.CreateElement("div");

            if (topCandidate != null) container.AppendChild(topCandidate.HtmlNode);

            result.DocumentNode.AppendChild(container);

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

        private double GetContentDensityScore(HtmlNode htmlNode)
        {
            var score = 0D;

            if (htmlNode.Name != "p") return score;

            var text = htmlNode.InnerText.RemoveWhitespace();

            if (string.IsNullOrEmpty(text)) return score;

            var sentances = text.Split('.');
            var sentanceCount = 0;

            foreach (var sentance in sentances)
            {
                if (string.IsNullOrWhiteSpace(sentance)) continue;

                sentanceCount++;

                if (sentanceCount > 3) break;

                var wordCount = sentance.Split(' ').Length;

                if (wordCount > 8 && wordCount < 12) score += 10D;
                if (wordCount > 12 && wordCount < 30) score += 25D;
                if (wordCount > 30 && wordCount < 35) score += 15D;
                if (wordCount > 35 && wordCount < 50) score += 5D;
            }

            return score;
        }

        private void EnsureCandidateScoreAttributes(HtmlNode htmlNode)
        {
            if (!htmlNode.Attributes.Contains("__score"))
            {
                htmlNode.SetAttributeValue("__id", Guid.NewGuid().ToString("D"));
                AddHtmlNodeScoreAttribute(htmlNode, GetElementWeightScore(htmlNode));
            }
        }

        private void AddHtmlNodeScoreAttribute(HtmlNode htmlNode, double score)
        {
            var current = Convert.ToDouble(htmlNode.GetAttributeValue("__score", "0.0"));

            htmlNode.SetAttributeValue("__score", (current + score).ToString(CultureInfo.InvariantCulture));
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

            if (links == null)
            {
                return 0D;
            }

            var linkLength = (double)links.Sum(l => l.InnerText.Length);
            var textLength = (double)htmlNode.InnerText.Length;

            return linkLength / textLength;
        }

        private double GetContentLengthScore(HtmlNode htmlNode)
        {
            // For every 100 characters in this htmlNode, add another point. Up to 3 points. 
            return Math.Min(Math.Floor(htmlNode.InnerText.Length / 100D), 3D);
        }

        private IEnumerable<HtmlNode> GetNodesToScore(HtmlDocument htmlDocument)
        {
            foreach (var htmlNode in htmlDocument.DocumentNode.SelectNodes("//*"))
            {
                if (htmlNode.ParentNode == null)
                {
                    continue;
                }

                if (htmlNode.InnerText.Length < 25)
                {
                    continue;
                }

                var name = htmlNode.Name.ToUpperInvariant();

                if (name == "P")
                {
                    yield return htmlNode;
                }

                if (name == "TD")
                {
                    yield return htmlNode;
                }

                if (name == "PRE")
                {
                    yield return htmlNode;
                }

                if (name == "#TEXT")
                {
                    yield return htmlNode;
                }
            }
        }

        private double GetClassWeightScore(HtmlNode htmlNode)
        {
            var classAttribute = htmlNode.Attributes["class"];

            if (classAttribute != null)
            {
                var className = classAttribute.Value;

                if (string.IsNullOrEmpty(className))
                {
                    return 0D;
                }

                if (IsNegativeCandidate(className))
                {
                    return -25D;
                }

                if (IsPositiveCandidate(className))
                {
                    return 25D;
                }
            }

            var id = htmlNode.Id;

            if (string.IsNullOrEmpty(id))
            {
                return 0D;
            }

            if (IsNegativeCandidate(id))
            {
                return -25D;
            }

            if (IsPositiveCandidate(id))
            {
                return 25D;
            }

            return 0D;
        }

        private double GetElementWeightScore(HtmlNode htmlNode)
        {
            switch (htmlNode.Name.ToUpperInvariant())
            {
                //case "P":   // I added this, seems reasonable
                //    return 7D;
                case "DIV":
                    return 5D;
                case "PRE":
                case "TD":
                case "BLOCKQUOTE":
                    return 3D;
                case "ADDRESS":
                case "OL":
                case "UL":
                case "DL":
                case "DD":
                case "DT":
                case "LI":
                case "FORM":
                    return -3D;
                case "H1":
                case "H2":
                case "H3":
                case "H4":
                case "H5":
                case "H6":
                case "TH":
                    return -5D;
            }

            return 0D;
        }

        private double GetContentCommaCountScore(HtmlNode htmlNode)
        {
            return htmlNode.InnerText.Split(',').Length;
        }

        private void ReplaceFonts(HtmlDocument htmlDocument)
        {
            var fonts = htmlDocument.DocumentNode.SelectNodes("//font");

            if (fonts == null)
            {
                return;
            }

            foreach (var font in fonts)
            {
                var value = font.InnerHtml;
                var span = htmlDocument.CreateElement("span");
                span.InnerHtml = value;

                font.ParentNode.ReplaceChild(span, font);
            }
        }

        private void ReplaceNonBlockDivCandidates(HtmlDocument htmlDocument)
        {
            // try convert non block divs to p 
            var nonBlockDivs = htmlDocument.DocumentNode
                                           .Descendants()
                                           .Where(n =>
                                                  n.Name.ToUpperInvariant() == "DIV" &&
                                                  IsNonBlockDiv(n.InnerHtml)).ToList();

            foreach (var nonBlockDiv in nonBlockDivs)
            {
                var value = nonBlockDiv.InnerHtml;
                var paragraph = htmlDocument.CreateElement("p");
                paragraph.InnerHtml = value;

                nonBlockDiv.ParentNode.ReplaceChild(paragraph, nonBlockDiv);
            }
        }

        private bool IsNonBlockDiv(string value)
        {
            return !DivToPElements.IsMatch(value);
        }

        private void RemoveUnlikelyCandidates(HtmlDocument htmlDocument)
        {
            // stripUnlikelyCandidates
            //  for each node, ignore body
            //      append the class and id together
            //      search that for stripUnlikelyCandidatesRegex
            //  if found then remove that node

            var byClassName = htmlDocument.DocumentNode
                                          .Descendants()
                                          .Where(n =>
                                              n.Name.ToUpperInvariant() != "BODY" &&
                                              n.Attributes.Contains("class") &&
                                              IsUnlikeyCandidate(n.Attributes["class"].Value))
                                              .ToList();

            for (var i = byClassName.Count() - 1; i >= 0; i--)
            {
                byClassName[i].Remove();
            }

            var byId = htmlDocument.DocumentNode
                                        .Descendants()
                                        .Where(n =>
                                            n.Name.ToUpperInvariant() != "BODY" &&
                                            IsUnlikeyCandidate(n.Id))
                                            .ToList();

            for (var i = byId.Count() - 1; i >= 0; i--)
            {
                byId[i].Remove();
            }
        }

        private bool IsUnlikeyCandidate(string value)
        {
            return UnlikeyCandidateRegex.IsMatch(value);
        }

        private bool IsNegativeCandidate(string value)
        {
            return NegativeCandidateRegex.IsMatch(value);
        }

        private bool IsPositiveCandidate(string value)
        {
            return PositiveCandidateRegex.IsMatch(value);
        }

        private void Normalize(HtmlDocument htmlDocument)
        {
            var cleaner = new Cleaners.HtmlCleaner();
            cleaner.Clean(htmlDocument);
            //cleaner.Clean(htmlDocument, "head");
            //cleaner.Clean(htmlDocument, "h1");
            //cleaner.Clean(htmlDocument, "header");
            //cleaner.Clean(htmlDocument, "footer");
            //cleaner.Clean(htmlDocument, "aside");
            //cleaner.Clean(htmlDocument, "hr");
            //cleaner.Clean(htmlDocument, "nav");

            EnsureBodyElement(htmlDocument);
            FindBestCandidateFrame(htmlDocument);
            RemoveUnlikelyCandidates(htmlDocument);
            ReplaceNonBlockDivCandidates(htmlDocument);
            ReplaceFonts(htmlDocument);
            ReplaceBrCandidates(htmlDocument);
            CleanImages(htmlDocument);
        }

        private void CleanImages(HtmlDocument htmlDocument)
        {
            var images = htmlDocument.DocumentNode.SelectNodes("//img");

            if (images == null)
            {
                return;
            }

            foreach (var image in images)
            {
                var altText = image.GetAttributeValue("alt", "");

                if (string.IsNullOrEmpty(altText))
                {
                    continue;
                }

                var figure = htmlDocument.CreateElement("figure");
                var caption = htmlDocument.CreateElement("figcaption");

                caption.InnerHtml = altText;

                figure.AppendChild(image.Clone());
                figure.AppendChild(caption);

                image.ParentNode.ReplaceChild(figure, image);
            }
        }

        private void RemoveAttribute(HtmlDocument htmlDocument, string attribute)
        {
            var elements = htmlDocument.DocumentNode.SelectNodes(string.Format("//@{0}", attribute));

            if (elements == null)
            {
                return;
            }

            foreach (var element in elements)
            {
                element.Attributes[attribute].Remove();
            }
        }

        private void ReplaceBrCandidates(HtmlDocument htmlDocument)
        {
            // Turn all double br's into p's 
            var lineBreaks = htmlDocument.DocumentNode.SelectNodes("//br");

            if (lineBreaks == null)
            {
                return;
            }

            var emptyParagraph = htmlDocument.CreateElement("p");
            emptyParagraph.InnerHtml = "&nbsp;";

            foreach (var lineBreak in lineBreaks)
            {
                if (lineBreak.PreviousSibling != null &&
                    lineBreak.PreviousSibling.Name == "br")
                {
                    lineBreak.PreviousSibling.Remove();
                    lineBreak.ParentNode.ReplaceChild(emptyParagraph, lineBreak);
                }
            }
        }

        private void EnsureBodyElement(HtmlDocument htmlDocument)
        {
            // if body element is missing then add it
            // why? do i care?
            // should be part of normalize/clean?


        }

        private void FindBestCandidateFrame(HtmlDocument htmlDocument)
        {

            // check if it has any frames
            // find the biggest frame on this domain...
            //  need url
            //


        }
    }
}

