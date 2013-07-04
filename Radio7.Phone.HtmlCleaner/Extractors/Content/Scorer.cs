using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner.Entities;
using Radio7.Phone.HtmlCleaner.Scorer;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class Scorer
    {
        private readonly INodeScorer _nodeSorer;
        private static readonly string[] ElementNamesToScore = new[] { "p", "td", "pre", "blockquote", "li", "div", "h2", "h3", "h4", "#text" };
        private const string IdAttributeName = "__content__id";
        private const string ScoreAttributeName = "__content__score";
        private const string RawScoreAttributeName = "__content__raw";
        private readonly List<CandidateNode> _candidateNodes = new List<CandidateNode>(64);

        public Scorer()
        {
            _nodeSorer = new GaussianContentDensityScorer();
        }

        public IEnumerable<CandidateNode> Score(HtmlDocument htmlDocument)
        {
            // TODO: to IFilter or something
            var nodesToScore = GetNodesToScore(htmlDocument);

            foreach (var htmlNode in nodesToScore)
            {
                EnsureCandidateScoreAttributes(htmlNode);
                EnsureCandidateScoreAttributes(htmlNode.ParentNode);

                var nodeStatistics = _nodeSorer.Score(htmlNode);

                // add raw score to self
                AddToHtmlNodeRawScoreAttribute(htmlNode, nodeStatistics.TotalScore);

                // add score to parent
                AddToHtmlNodeScoreAttribute(htmlNode.ParentNode, nodeStatistics.TotalScore);
                UpdateCandidateNode(htmlNode.ParentNode);

                if (htmlNode.ParentNode.ParentNode == null) continue;
                if (htmlNode.ParentNode.ParentNode.Name == "body") continue;

                EnsureCandidateScoreAttributes(htmlNode.ParentNode.ParentNode);
                // add half to grandparent
                AddToHtmlNodeScoreAttribute(htmlNode.ParentNode.ParentNode, nodeStatistics.TotalScore / 2D);
                UpdateCandidateNode(htmlNode.ParentNode.ParentNode);
                UpdateCandidateRawScore(htmlNode);
            }

            ScaleCandidateScoresByLinkDensity(_candidateNodes);

            return _candidateNodes;
        }

        private void ScaleCandidateScoresByLinkDensity(IEnumerable<CandidateNode> candidateNodes)
        {
            foreach (var candidateNode in candidateNodes)
            {
                var linkDensity = GetLinkDensityScore(candidateNode.HtmlNode);
                candidateNode.Score = candidateNode.Score * (1 - linkDensity);
            }
        }

        private double GetLinkDensityScore(HtmlNode htmlNode)
        {
            var links = htmlNode.SelectNodes("a");

            if (links == null) return 0D;

            var linkLength = (double)links.Sum(l => l.InnerText.Length);
            var textLength = (double)htmlNode.InnerText.Length;

            return linkLength / textLength;
        }

        private IEnumerable<HtmlNode> GetNodesToScore(HtmlDocument htmlDocument)
        {
            foreach (var htmlNode in htmlDocument.DocumentNode.SelectNodes("//*"))
            {
                if (htmlNode.ParentNode == null) continue;
                if (htmlNode.ParentNode.Name == "body") continue;
                if (htmlNode.InnerText.Length < 25) continue;

                if (ElementNamesToScore.Contains(htmlNode.Name)) yield return htmlNode;
            }
        }

        private void UpdateCandidateRawScore(HtmlNode htmlNode)
        {
            var score = Convert.ToDouble(htmlNode.GetAttributeValue(ScoreAttributeName, "0.0"));
            var rawScore = Convert.ToDouble(htmlNode.GetAttributeValue(RawScoreAttributeName, "0.0"));
            var id = Guid.Parse(htmlNode.GetAttributeValue(IdAttributeName, Guid.Empty.ToString("D")));

            var candidateNode = new CandidateNode
            {
                HtmlNode = htmlNode,
                Score = score,
                RawScore = rawScore,
                Id = id
            };

            if (_candidateNodes.Any(c => c.Id == id))
            {
                _candidateNodes.First(c => c.Id == id).RawScore = rawScore;
                return;
            }

            _candidateNodes.Add(candidateNode);
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
            // TODO: refactor to INodeScorer or something
            // TODO: try with an exponential modifier to push good results
            // through the roof.  then we could try and extract just the content
            // and build our own tree
            // might let us avoid the whole normalize and clean crap
            // might also let us test any node instead of these candidates

            var score = 0D;
            var weight = 1D;

            if (htmlNode.Name == "p") weight = 10D;
            if (htmlNode.Name == "pre") weight = 5D;
            if (htmlNode.Name == "td") weight = 2D;
            if (htmlNode.Name == "#text") weight = 5D;
            if (htmlNode.Name == "h2") weight = 5D;
            if (htmlNode.Name == "h3") weight = 5D;
            if (htmlNode.Name == "h4") weight = 2D;
            if (htmlNode.Name == "h5") weight = 2D;

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

            

            return score * weight;
        }

        private double GetThresholdScore(double x)
        {
            var result = Math.Exp(x - 200);

            if (result > 10000000000D) result = 10000000000D;
            if (double.IsPositiveInfinity(result)) result = 10000000000D;

            return result;
        }

        private void EnsureCandidateScoreAttributes(HtmlNode htmlNode)
        {
            if (htmlNode.Attributes.Contains(ScoreAttributeName)) return;

            htmlNode.SetAttributeValue(IdAttributeName, Guid.NewGuid().ToString("D"));
            htmlNode.SetAttributeValue(RawScoreAttributeName, "0.0");
            AddToHtmlNodeScoreAttribute(htmlNode, 0D);
        }

        private void AddToHtmlNodeScoreAttribute(HtmlNode htmlNode, double score)
        {
            var current = Convert.ToDouble(htmlNode.GetAttributeValue(ScoreAttributeName, "0.0"));
            htmlNode.SetAttributeValue(ScoreAttributeName, (current + score).ToString(CultureInfo.InvariantCulture));
        }

        private void AddToHtmlNodeRawScoreAttribute(HtmlNode htmlNode, double score)
        {
            var current = Convert.ToDouble(htmlNode.GetAttributeValue(RawScoreAttributeName, "0.0"));
            htmlNode.SetAttributeValue(RawScoreAttributeName, (current + score).ToString(CultureInfo.InvariantCulture));
        }
    }
}
