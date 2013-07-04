using System;

namespace Radio7.Phone.News.Services
{
    public interface INewsService
    {
        void BeginGetNews(Uri url);

        event EventHandler<GetNewsCompleteEventArgs> GetNewsComplete;
    }
}