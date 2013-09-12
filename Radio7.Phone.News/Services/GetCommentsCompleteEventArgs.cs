using System;

namespace Radio7.Phone.News.Services
{
    public class GetCommentsCompleteEventArgs : EventArgs
    {
        public GetCommentsCompleteEventArgs(string commentsHtml)
        {
            CommentsHtml = commentsHtml;
        }

        public string CommentsHtml { get; set; }
    }
}