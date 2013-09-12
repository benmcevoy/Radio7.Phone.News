using System.Collections.Generic;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.Services.Comments
{
    public interface ICommentExtractor
    {
        IEnumerable<Comment> Extract(string html);
    }
}
