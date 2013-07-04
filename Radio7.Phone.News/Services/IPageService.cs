using System;

namespace Radio7.Phone.News.Services
{
    public interface IPageService
    {
        void BeginGetPage(Uri uri);

        event EventHandler<GetPageCompleteEventArgs> GetPageComplete;
    }
}