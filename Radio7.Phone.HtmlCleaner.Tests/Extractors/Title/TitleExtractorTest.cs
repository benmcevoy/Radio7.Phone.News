using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Radio7.Phone.HtmlCleaner.Extractors.Title;

namespace Radio7.Phone.HtmlCleaner.Tests.Extractors.Title
{
    [TestClass]
    public class TitleExtractorTest
    {
        [TestMethod]
        public void Extract_WithAgeArticleHtml_ReturnsTitle()
        {
            // arrange
            var extractor = new TitleExtractor();
            // act
            var result = extractor.Extract(AgeArticle.Html);

            // assert
            Assert.AreEqual("Girl, 17, dies in southeast Queensland crash", result);
        }

        [TestMethod]
        public void Extract_WithABCHtml_ReturnsTitle()
        {
            // arrange
            var extractor = new TitleExtractor();
            // act
            var result = extractor.Extract(ABC.Html);

            // assert
            Assert.AreEqual("Labor announces three new women in Labor Cabinet reshuffle", result);
        }

        [TestMethod]
        public void Extract_WithRLeagueHtml_ReturnsTitle()
        {
            // arrange
            var extractor = new TitleExtractor();
            // act
            var result = extractor.Extract(RLeague.Html);

            // assert
            Assert.AreEqual("Waerea-Hargreaves fired up for NRL return", result);
        }

        [TestMethod]
        public void Extract_WithSunshineCoastDailyHtml_ReturnsTitle()
        {
            // arrange
            var extractor = new TitleExtractor();
            // act
            var result = extractor.Extract(SunshineCoastDaily.Html);

            // assert
            Assert.AreEqual("Legionella scare in Sunshine Coast Private Hospital", result);
        }

        [TestMethod]
        public void Extract_WithTheAustralianHtml_ReturnsTitle()
        {
            // arrange
            var extractor = new TitleExtractor();
            // act
            var result = extractor.Extract(TheAustralian.Html);

            // assert
            Assert.AreEqual("Abortion drug overshadows new PBS listings", result);
        }
    }
}
