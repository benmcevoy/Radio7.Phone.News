using System.Collections.Generic;
using System.Linq;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.Services.Comments
{
    public class DefaultCommentExtractor : ICommentExtractor
    {
        public IEnumerable<Comment> Extract(string html)
        {
            return Enumerable.Empty<Comment>();
        }
    }
}
