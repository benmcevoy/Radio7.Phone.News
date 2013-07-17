using HtmlAgilityPack;
using Radio7.Phone.HtmlCleaner.Entities;

namespace Radio7.Phone.HtmlCleaner.Scorer
{
    public interface INodeScorer
    {
        SentanceStatistics Score(HtmlNode htmlNode);
    }
}
