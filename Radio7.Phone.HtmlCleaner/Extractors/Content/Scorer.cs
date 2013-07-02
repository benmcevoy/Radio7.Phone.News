using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner.Entities;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public class Scorer
    {
        private const string IdAttributeName = "__content__id";
        private const string ScoreAttributeName = "__content__score";
        private readonly List<CandidateNode> _candidateNodes = new List<CandidateNode>(64);

        public IEnumerable<CandidateNode> Score(HtmlDocument htmlDocument)
        {
            var nodesToScore = GetNodesToScore(htmlDocument);

            foreach (var htmlNode in nodesToScore)
            {
                if (htmlNode.ParentNode == null) continue;
                if (htmlNode.ParentNode.Name == "body") continue;

                EnsureCandidateScoreAttributes(htmlNode.ParentNode);

                var score = GetContentDensityScore(htmlNode);

                // add score to parent
                AddToHtmlNodeScoreAttribute(htmlNode.ParentNode, score);

                UpdateCandidateNode(htmlNode.ParentNode);

                if (htmlNode.ParentNode.ParentNode == null) continue;
                if (htmlNode.ParentNode.ParentNode.Name == "body") continue;

                EnsureCandidateScoreAttributes(htmlNode.ParentNode.ParentNode);

                // add half to grandparent
                AddToHtmlNodeScoreAttribute(htmlNode.ParentNode.ParentNode, score / 2D);

                UpdateCandidateNode(htmlNode.ParentNode.ParentNode);
            }

            return _candidateNodes;
        }

        private IEnumerable<HtmlNode> GetNodesToScore(HtmlDocument htmlDocument)
        {
            foreach (var htmlNode in htmlDocument.DocumentNode.SelectNodes("//*"))
            {
                if (htmlNode.ParentNode == null) continue;
                if (htmlNode.ParentNode.Name == "body") continue;
                if (htmlNode.InnerText.Length < 25) continue;

                var name = htmlNode.Name;

                if (name == "p") yield return htmlNode;
                if (name == "td") yield return htmlNode;
                if (name == "pre") yield return htmlNode;
                if (name == "li") yield return htmlNode;
                if (name == "div") yield return htmlNode;
                if (name == "#text") yield return htmlNode;
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
            // TODO: refactor to INodeScorer or something
            // TODO: try with an exponential modifier to push good results
            // through the roof.  then we could try and extract just the content
            // and build our own tree
            // might let us avoid the whole normalize and clean crap
            // might also let us test any node instead of these candidates

            var score = 1D;
            var weight = 1D;

            if (htmlNode.Name == "p") weight = 10D;
            if (htmlNode.Name == "pre") weight = 5D;
            if (htmlNode.Name == "td") weight = 2D;
            if (htmlNode.Name == "#text") weight = 5D;

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

        private void EnsureCandidateScoreAttributes(HtmlNode htmlNode)
        {
            if (htmlNode.Attributes.Contains(ScoreAttributeName)) return;

            htmlNode.SetAttributeValue(IdAttributeName, Guid.NewGuid().ToString("D"));
            AddToHtmlNodeScoreAttribute(htmlNode, 0D);
        }

        private void AddToHtmlNodeScoreAttribute(HtmlNode htmlNode, double score)
        {
            var current = Convert.ToDouble(htmlNode.GetAttributeValue(ScoreAttributeName, "0.0"));
            htmlNode.SetAttributeValue(ScoreAttributeName, (current + score).ToString(CultureInfo.InvariantCulture));
        }
    }
}
