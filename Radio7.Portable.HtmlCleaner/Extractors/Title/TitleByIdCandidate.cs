using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Extractors.Title
{
    public class TitleByIdCandidate : Candidate
    {
        public override HtmlResult Evaluate(HtmlDocument htmlDocument)
        {
            var result = htmlDocument.TryGetInnerTextByElementId("title");
            return result.IsSuccess ? result : base.Evaluate(htmlDocument);
        }
    }
}