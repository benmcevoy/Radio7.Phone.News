using GalaSoft.MvvmLight;
using System;
using Radio7.Phone.News.Services;

namespace Radio7.Phone.News.ViewModels
{
    public class ItemPageViewModel : ViewModelBase
    {
        private readonly IPageService _pageService;

        public ItemPageViewModel(IPageService pageService)
        {
            _pageService = pageService;
            _pageService.GetPageComplete += PageServiceOnGetPageComplete;
        }

        private void PageServiceOnGetPageComplete(object sender, GetPageCompleteEventArgs getPageCompleteEventArgs)
        {
            if (NavigateToString != null)
            {
                NavigateToString(this, new NavigateToStringEventArgs(getPageCompleteEventArgs.Content));
            }
        }

        public void BeginLoad(Uri url)
        {
            _pageService.BeginGetPage(url);
        }

        // TODO: replace with messaging
        public event EventHandler<NavigateToStringEventArgs> NavigateToString;
    }
}
