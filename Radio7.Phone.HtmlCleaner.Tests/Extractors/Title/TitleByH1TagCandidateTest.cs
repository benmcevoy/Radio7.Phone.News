using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Radio7.Phone.HtmlCleaner.Extractors.Title;

namespace Radio7.Phone.HtmlCleaner.Tests.Extractors.Title
{
    [TestClass]
    public class TitleByH1TagCandidateTest
    {
        [TestMethod]
        public void Evaluate_WithValidHtml_FindsTitle()
        {
            // arrange
            var target = new TitleByH1TagCandidate();
            
            // act
            var result = target.Evaluate(AgeArticle.HtmlDocument);

            // assert
            Assert.AreEqual(true, result.IsSuccess);
        }

    }
}
