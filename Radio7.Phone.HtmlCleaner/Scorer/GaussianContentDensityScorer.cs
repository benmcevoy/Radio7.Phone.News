using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner.Entities;

namespace Radio7.Phone.HtmlCleaner.Scorer
{
    class GaussianContentDensityScorer : INodeScorer
    {
        public SentanceStatistics Score(HtmlNode htmlNode)
        {
            var text = htmlNode.InnerText.RemoveWhitespace();

            if (string.IsNullOrEmpty(text)) return new SentanceStatistics();

            var sentances = text.Split(new[] { ".", "?", "!", ";", ".\"", "?\"", "!\"", "|" }, StringSplitOptions.RemoveEmptyEntries);
            var sentanceCount = sentances.Count();
            var sentanceScores = new List<SentanceScore>(sentanceCount);

            foreach (var sentance in sentances)
            {
                if (string.IsNullOrWhiteSpace(sentance)) continue;

                var wordCount = sentance.Split(' ').Length;

                var score = GetProbabilty(wordCount) * 500D;

                sentanceScores.Add(new SentanceScore
                    {
                        Score = score,
                        WordCount = wordCount
                    });
            }

            return new SentanceStatistics
                {
                    SentanceCount = sentanceCount,
                    SentanceScores = sentanceScores
                };
        }

        private double GetProbabilty(double x)
        {
            const double mean = 14.3D; // average sentance length
            //const double standardDeviation = 5D;
            //const double squareRoot2Pi = 2.50662827463D;
            const double standardDeviationSquareBy2 = 50D;
            const double inverseStandardDeviationBysquareRoot2Pi = 0.0797884560800001D;

            return (inverseStandardDeviationBysquareRoot2Pi *
                    Math.Exp(-(Math.Pow(x - mean, 2D) / standardDeviationSquareBy2))) * 100D;

        }

        private double GetThresholdScore(double x)
        {
            var result = Math.Exp(x - 200);

            if (result > 10000000000D) result = 10000000000D;
            if (double.IsPositiveInfinity(result)) result = 10000000000D;

            return result;
        }
    }
}
