using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner.Models;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class Scorer
    {
        private const string IdAttributeName = "__content__id";
        private const string ScoreAttributeName = "__content__score";

        private readonly List<CandidateNode> _candidateNodes = new List<CandidateNode>(64);

        private static readonly Regex PositiveCandidateRegex =
            new Regex(
                @"article|body|content|entry|hentry|main|page|pagination|" +
                "post|blog|story|articleBody",
                RegexOptions.Compiled & RegexOptions.IgnoreCase);

        private static readonly Regex NegativeCandidateRegex =
            new Regex(
                @"combx|comment|com-|contact|foot|footer|footnote|masthead|" +
                "media|meta|outbrain|promo|related|scroll|shoutbox|sidebar|" +
                "sponsor|shopping|tags|tool|widget|metadata|overlay|video|nav|modal",
                RegexOptions.Compiled & RegexOptions.IgnoreCase);

        public IEnumerable<CandidateNode> Score(HtmlDocument htmlDocument)
        {
            var nodesToScore = GetNodesToScore(htmlDocument);

            foreach (var htmlNode in nodesToScore)
            {
                if (htmlNode.ParentNode == null) continue;
                if (htmlNode.ParentNode.Name == "body") continue;

                EnsureCandidateScoreAttributes(htmlNode.ParentNode);

                var score = 1D;

                score += GetElementWeightScore(htmlNode);
                score += GetClassWeightScore(htmlNode);
                score += GetContentDensityScore(htmlNode);

                // add score to parent
                AddHtmlNodeScoreAttribute(htmlNode.ParentNode, score);

                UpdateCandidateNode(htmlNode.ParentNode);

                if (htmlNode.ParentNode.ParentNode == null) continue;
                if (htmlNode.ParentNode.ParentNode.Name == "body") continue;

                EnsureCandidateScoreAttributes(htmlNode.ParentNode.ParentNode);

                // add half to grandparent
                AddHtmlNodeScoreAttribute(htmlNode.ParentNode.ParentNode, score / 2D);

                UpdateCandidateNode(htmlNode.ParentNode.ParentNode);
            }

            return _candidateNodes;
        }

        private IEnumerable<HtmlNode> GetNodesToScore(HtmlDocument htmlDocument)
        {
            foreach (var htmlNode in htmlDocument.DocumentNode.SelectNodes("//*"))
            {
                if (htmlNode.ParentNode == null) continue;
                if (htmlNode.InnerText.Length < 25) continue;

                var name = htmlNode.Name.ToUpperInvariant();

                if (name == "P") yield return htmlNode;
                if (name == "TD") yield return htmlNode;
                if (name == "PRE") yield return htmlNode;
                if (name == "LI") yield return htmlNode;
                if (name == "DIV") yield return htmlNode;
                if (name == "#TEXT") yield return htmlNode;
            }
        }

        private void UpdateCandidateNode(HtmlNode htmlNode)
        {
            var score = Convert.ToDouble(htmlNode.GetAttributeValue(ScoreAttributeName, "0.0"));
            var id = Guid.Parse(htmlNode.GetAttributeValue(IdAttributeName, Guid.Empty.ToString("D")));

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

        private double GetContentDensityScore(HtmlNode htmlNode)
        {
            var score = 0D;
            var modifier = 1.0D;

            if (htmlNode.Name == "p") modifier = 5D;
            if (htmlNode.Name == "li") modifier = 2D;
            if (htmlNode.Name == "pre") modifier = 2D;
            if (htmlNode.Name == "td") modifier = 2D;

            var text = htmlNode.InnerText.RemoveWhitespace();

            if (string.IsNullOrEmpty(text)) return score;

            var sentances = text.Split(new[] { '.', '?', '!', ';' });

            foreach (var sentance in sentances)
            {
                if (string.IsNullOrWhiteSpace(sentance)) continue;

                var wordCount = sentance.Split(' ').Length;

                if (wordCount > 8 && wordCount < 12) score += 50D;
                if (wordCount > 12 && wordCount < 30) score += 300D;
                if (wordCount > 30 && wordCount < 35) score += 200D;
                if (wordCount > 35 && wordCount < 50) score += 50D;
            }

            return score * modifier;
        }

        private void EnsureCandidateScoreAttributes(HtmlNode htmlNode)
        {
            if (htmlNode.Attributes.Contains(ScoreAttributeName)) return;

            htmlNode.SetAttributeValue(IdAttributeName, Guid.NewGuid().ToString("D"));
            AddHtmlNodeScoreAttribute(htmlNode, GetElementWeightScore(htmlNode));
        }

        private void AddHtmlNodeScoreAttribute(HtmlNode htmlNode, double score)
        {
            var current = Convert.ToDouble(htmlNode.GetAttributeValue(ScoreAttributeName, "0.0"));

            htmlNode.SetAttributeValue(ScoreAttributeName, (current + score).ToString(CultureInfo.InvariantCulture));
        }

        private double GetClassWeightScore(HtmlNode htmlNode)
        {
            var classAttribute = htmlNode.Attributes["class"];

            if (classAttribute != null)
            {
                var className = classAttribute.Value;

                if (string.IsNullOrEmpty(className)) return 0D;
                if (IsNegativeCandidate(className)) return -25D;
                if (IsPositiveCandidate(className)) return 25D;
            }

            var id = htmlNode.Id;

            if (string.IsNullOrEmpty(id)) return 0D;
            if (IsNegativeCandidate(id)) return -25D;
            if (IsPositiveCandidate(id)) return 25D;

            return 0D;
        }

        private double GetElementWeightScore(HtmlNode htmlNode)
        {
            switch (htmlNode.Name.ToUpperInvariant())
            {
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

        private bool IsNegativeCandidate(string value)
        {
            return !string.IsNullOrEmpty(value) && NegativeCandidateRegex.IsMatch(value);
        }

        private bool IsPositiveCandidate(string value)
        {
            return !string.IsNullOrEmpty(value) && PositiveCandidateRegex.IsMatch(value);
        }
    }
}
