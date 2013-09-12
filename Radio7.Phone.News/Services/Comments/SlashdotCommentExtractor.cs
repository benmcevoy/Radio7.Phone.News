using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.News.Models;
using Radio7.Portable.StrategyResolver;

namespace Radio7.Phone.News.Services.Comments
{
    [StrategyFor("rss.slashdot.org")]
    public class SlashdotCommentExtractor : ICommentExtractor
    {
        public IEnumerable<Comment> Extract(string html)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            return GetCommentNodes(htmlDocument)
                .Select(node => new Comment { Body = GetBody(node) })
                .ToList();
        }

        private string GetBody(HtmlNode node)
        {
            var commentTitle = node.SelectNodes("descendant::div[@class='title']");
            var commentBody = node.SelectNodes("descendant::div[@class='commentBody']");
            var result = "";

            if (commentTitle != null)
            {
                result = "<h3>" + commentTitle.First().InnerText.Trim() + "</h3>";
            }

            if (commentBody != null)
            {
                result += "<div class='comment'>" + commentBody.First().InnerHtml.Trim() + "</div>";
            }

            return result;
        }

        private IEnumerable<HtmlNode> GetCommentNodes(HtmlDocument htmlDocument)
        {
            if (htmlDocument.DocumentNode.FirstChild == null) return Enumerable.Empty<HtmlNode>();

            var nodes = htmlDocument.DocumentNode.SelectNodes("//li[@class='comment full contain']");

            if (nodes == null) return Enumerable.Empty<HtmlNode>();

            return nodes;
        }
    }
}
