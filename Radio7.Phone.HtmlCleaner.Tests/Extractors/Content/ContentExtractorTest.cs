using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Radio7.Phone.HtmlCleaner.Extractors.Content;

namespace Radio7.Phone.HtmlCleaner.Tests.Extractors.Content
{
    [TestClass]
    public class ContentExtractorTest
    {
        [TestMethod]
        public void Extract_WithValidHtml_Succeeds()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(AgeArticle.Html, new Uri("http://www.test.com"));
            
            // assert
        }

        [TestMethod]
        public void Extract_WithAgeArticleHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(AgeArticle.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void Extract_WithWikipediaHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(Wikipedia.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void Extract_WithStackOverflowHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(StackoverFlow.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void Extract_WithABCHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(ABC.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void Extract_WithRLeagueHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(RLeague.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void Extract_WithSunshineCoastDailyHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(SunshineCoastDaily.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void Extract_WithTheAustralianHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(TheAustralian.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }


        [TestMethod]
        public void Extract_WithSMHHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(SMH.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }


        [TestMethod]
        public void Extract_WithGulfNewsHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(GulfNews.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }


        [TestMethod]
        public void Extract_WitBBCHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(BBC.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void Extract_WithNewYorkTimesHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(NewYorkTimes.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }

        [TestMethod]
        public void Extract_WithWSJHtml_ReturnsContent()
        {
            // arrange
            var target = new ContentExtractor();

            // act
            var result = target.Extract(WSJ.Html, new Uri("http://www.test.com"));

            // assert
            Assert.AreNotEqual("", result);
        }
    }
}
