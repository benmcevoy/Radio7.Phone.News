using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Linq;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class Normalizer
    {
        private readonly HtmlDocument _htmlDocument;

        private static readonly Regex UnlikeyCandidateRegex = new Regex(
            @"combx|comment|community|disqus|extra|foot|header|menu|remark|rss|shoutbox|sidebar|" +
            "sponsor|ad-break|agegate|pagination|pager|popup|tweet|twitter|hidden|aside|advert|" +
            "overlay|nav|sub-nav|share|toolbar|playlist|addthis|social|modal",
            RegexOptions.Compiled & RegexOptions.IgnoreCase);

        private static readonly Regex DivToPElements = new Regex(
            @"/<(a|blockquote|dl|div|img|ol|p|pre|table|ul)",
            RegexOptions.Compiled & RegexOptions.IgnoreCase);

        public Normalizer(HtmlDocument htmlDocument)
        {
            _htmlDocument = htmlDocument;
        }

        public Normalizer FindBestCandidateFrame()
        {
            // check if it has any frames
            // find the biggest frame on this domain...
            //  need url

            return this;
        }

        private void ProcessElements(IList<HtmlNode> elements, Action<HtmlNode> action)
        {
            if (elements == null) return;

            for (var i = elements.Count - 1; i >= 0; i--)
            {
                var element = elements[i];
                action(element);
            }
        }

        public Normalizer CleanImages()
        {
            var elements = _htmlDocument.DocumentNode.SelectNodes("//img");

            ProcessElements(elements, image =>
                {
                    var altText = image.GetAttributeValue("alt", "");

                    if (string.IsNullOrEmpty(altText)) return;

                    var figure = _htmlDocument.CreateElement("figure");
                    var caption = _htmlDocument.CreateElement("figcaption");

                    caption.InnerHtml = altText;

                    figure.AppendChild(image.Clone());
                    figure.AppendChild(caption);

                    image.ParentNode.ReplaceChild(figure, image);
                });

            return this;
        }

        public Normalizer ReplaceBrCandidates()
        {
            // Turn all double br's into p's 
            var elements = _htmlDocument.DocumentNode.SelectNodes("//br");

            ProcessElements(elements, element =>
                {
                    var emptyParagraph = _htmlDocument.CreateElement("p");
                    emptyParagraph.InnerHtml = "&nbsp;";

                    if (element.NextSibling == null || element.NextSibling.Name != "br") return;

                    element.NextSibling.Remove();
                    element.ParentNode.ReplaceChild(emptyParagraph, element);
                });

            return this;
        }

        public Normalizer EnsureBodyElement()
        {
            // if body element is missing then add it
            // why? do i care?
            // should be part of normalize/clean?

            return this;
        }

        public Normalizer ReplaceFonts()
        {
            var elements = _htmlDocument.DocumentNode.SelectNodes("//font");

            ProcessElements(elements, element =>
                {
                    var value = element.InnerHtml;
                    var span = _htmlDocument.CreateElement("span");
                    span.InnerHtml = value;

                    element.ParentNode.ReplaceChild(span, element);
                });

            return this;
        }

        public Normalizer RemoveEmptyCandidateElements()
        {
            var elements = _htmlDocument.DocumentNode
                                      .Descendants()
                                      .Where(n =>
                                          n.Name.ToUpperInvariant() != "BODY" &&
                                          (n.Name == "div" || n.Name == "span"))
                                          .ToList();

            ProcessElements(elements, element =>
                {
                    if (string.IsNullOrEmpty(element.InnerHtml.RemoveWhitespace()))
                    {
                        element.Remove();
                    }
                });

            return this;
        }

        public Normalizer RemoveUnlikelyCandidates()
        {
            // stripUnlikelyCandidates
            //  for each node, ignore body
            //      append the class and id together
            //      search that for stripUnlikelyCandidatesRegex
            //  if found then remove that node

            var byClassName = _htmlDocument.DocumentNode
                                          .Descendants()
                                          .Where(n =>
                                              n.Name.ToUpperInvariant() != "BODY" &&
                                              n.Attributes.Contains("class") &&
                                              IsUnlikeyCandidate(n.Attributes["class"].Value))
                                              .ToList();

            ProcessElements(byClassName, element => element.Remove());

            var byId = _htmlDocument.DocumentNode
                                        .Descendants()
                                        .Where(n =>
                                            n.Name.ToUpperInvariant() != "BODY" &&
                                            IsUnlikeyCandidate(n.Id))
                                            .ToList();

            ProcessElements(byId, element => element.Remove());

            return this;
        }

        private bool IsUnlikeyCandidate(string value)
        {
            return !string.IsNullOrEmpty(value) && UnlikeyCandidateRegex.IsMatch(value);
        }

        public Normalizer ReplaceNonBlockDivCandidates()
        {
            // try convert non block divs to p 
            var elements = _htmlDocument.DocumentNode
                                           .Descendants()
                                           .Where(n =>
                                                  n.Name.ToUpperInvariant() == "DIV" &&
                                                  IsNonBlockDiv(n.InnerHtml)).ToList();

            ProcessElements(elements, element =>
                {
                    var value = element.InnerHtml;
                    var paragraph = _htmlDocument.CreateElement("p");
                    paragraph.InnerHtml = value;

                    element.ParentNode.ReplaceChild(paragraph, element);
                });

            return this;
        }

        private bool IsNonBlockDiv(string value)
        {
            return !string.IsNullOrEmpty(value) && !DivToPElements.IsMatch(value);
        }
    }
}
