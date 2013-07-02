using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Radio7.Phone.HtmlCleaner.Extractors.Title;

namespace Radio7.Phone.HtmlCleaner.Tests.Extractors.Title
{
    [TestClass]
    public class TitleByTitleTagCandidateTest
    {
        [TestMethod]
        public void Evaluate_WithValidHtml_FindsTitle()
        {
            // arrange
            var target = new TitleByTitleTagCandidate();

            // act
            var result = target.Evaluate(AgeArticle.HtmlDocument);

            // assert
            Assert.AreEqual(true, result.IsSuccess);
        }
    }
}
