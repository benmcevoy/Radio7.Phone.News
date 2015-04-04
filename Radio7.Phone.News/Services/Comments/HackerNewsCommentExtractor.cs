using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using Radio7.Phone.News.Models;
using Radio7.Portable.StrategyResolver;

namespace Radio7.Phone.News.Services.Comments
{
    [StrategyFor("news.ycombinator.com")]
    public class HackerNewsCommentExtractor : ICommentExtractor
    {
        public IEnumerable<Comment> Extract(string html)
        {
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            return GetCommentNodes(htmlDocument)
                .Select(node => new Comment { Body = GetBody(node) })
                .ToList();
        }

        private IEnumerable<HtmlNode> GetCommentNodes(HtmlDocument htmlDocument)
        {
            if (htmlDocument.DocumentNode.FirstChild == null) yield break;

            var nodes = htmlDocument.DocumentNode.SelectNodes("//td[@class='default']");

            if (nodes == null) yield break;

            foreach (var htmlNode in nodes)
            {
                yield return htmlNode;
            }
        }

        private string GetBody(HtmlNode node)
        {
            var commentTitle = node.SelectNodes("descendant::span[@class='comhead']");
            var commentBody = node.SelectNodes("descendant::span[@class='comment']");
            var result = "";

            if (commentTitle != null)
            {
                var title = commentTitle.First().InnerText.Trim();

                result = string.Format("<h3>{0}</h3>", title.Trim());
            }

            if (commentBody != null)
            {
                result += string.Format("<div class='comment'>{0}</div>", commentBody.First().InnerHtml.Trim());
            }

            return result;
        }
    }
}
