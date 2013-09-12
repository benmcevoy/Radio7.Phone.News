using System;

namespace Radio7.Phone.News.Services
{
    public interface ICommentService
    {
        void BeginGetComments(Uri url);
        event EventHandler<GetCommentsCompleteEventArgs> GetCommentsComplete;
    }
}