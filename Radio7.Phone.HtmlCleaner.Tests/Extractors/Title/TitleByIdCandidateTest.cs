using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Radio7.Phone.HtmlCleaner.Extractors.Title;

namespace Radio7.Phone.HtmlCleaner.Tests.Extractors.Title
{
    [TestClass]
    public class TitleByIdCandidateTest
    {
        [TestMethod]
        public void Evaluate_WithInValidHtml_DoesNotFindTitle()
        {
            // arrange
            var target = new TitleByIdCandidate();

            // act
            var result = target.Evaluate(AgeArticle.HtmlDocument);

            // assert
            Assert.AreEqual(false, result.IsSuccess);
        }
    }
}
