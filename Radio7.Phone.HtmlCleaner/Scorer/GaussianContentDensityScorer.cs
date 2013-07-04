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

            var sentances = text.Split(new[] { '.', '?', '!', ';' });
            var score = 0D;
            var weight = 500D;
            var sentanceCount = sentances.Count();
            var sentanceScores = new List<SentanceScore>(sentanceCount);

            foreach (var sentance in sentances)
            {
                if (string.IsNullOrWhiteSpace(sentance)) continue;

                var wordCount = sentance.Split(' ').Length;

                sentanceScores.Add(new SentanceScore
                    {
                        Score = score * weight,
                        WordCount = wordCount
                    });

                score += GetProbabilty(wordCount);
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
                    Math.Exp(-(Math.Pow(x - mean, 2D) / standardDeviationSquareBy2)));
        }

        //private double GetNormalProbabilty(double x, double mean, double standardDeviation)
        //{
        //    return (1D / standardDeviation * (Math.Sqrt(2 * Math.PI)) *
        //            Math.Exp(-(Math.Pow(x - mean, 2D) / 2D * Math.Pow(standardDeviation, 2))));


        //}
    }
}
