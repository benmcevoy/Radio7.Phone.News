using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    [TestClass]
    public class HtmlHelperTest
    {
        [TestMethod]
        public void RemoveDodgyCharacters_WithDodgy_ReturnsClean()
        {
            // arrange
            const string dodgy = @"some \|{[~1$56Djhkd

dodgy";

            // act
            var result = dodgy.RemoveDodgyCharacters();

            // assert
            Assert.AreEqual(@"some \   1$56Djhkd    dodgy", result);
        }

        [TestMethod]
        public void RemoveWhitespace_WithSpaces_RemovesWhitespace()
        {
            // arrange
            const string input = " a b    c def g  ";

            // act
            var result = input.RemoveWhitespace();

            // assert
            Assert.AreEqual("a b c def g", result);
        }

        [TestMethod]
        public void RemoveWhitespace_WithWhitespaces_RemovesWhitespace()
        {
            // arrange
            const string input = @" a b      

            tabs

c def g  ";

            // act
            var result = input.RemoveWhitespace();

            // assert
            Assert.AreEqual("a b tabs c def g", result);
        }
    }
}
