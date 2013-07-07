using GalaSoft.MvvmLight;
using System;
using GalaSoft.MvvmLight.Command;
using Radio7.Phone.News.Services;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.ViewModels
{
    public class ItemPageViewModel : ViewModelBase
    {
        private readonly IPageService _pageService;

        public ItemPageViewModel(IPageService pageService)
        {
            _pageService = pageService;
            _pageService.GetPageComplete += PageServiceOnGetPageComplete;

            ContentLevelCommand = new RelayCommand<ContentLevel>(SetContentLevel);
        }

        private void SetContentLevel(ContentLevel contentLevel)
        {
            switch (contentLevel)
            {
                case ContentLevel.Summary:
                    RaiseNavigateToString(Summary, Original);
                    break;
                case ContentLevel.Article:
                    RaiseNavigateToString(Article, Original);
                    break;
                case ContentLevel.Original:
                    RaiseNavigateToString("", Original);
                    break;
            }
        }

        private void PageServiceOnGetPageComplete(object sender, GetPageCompleteEventArgs getPageCompleteEventArgs)
        {
            Title = getPageCompleteEventArgs.Title;
            Summary = getPageCompleteEventArgs.Summary;
            Article = getPageCompleteEventArgs.Html;
            Original = getPageCompleteEventArgs.Url;

            SetContentLevel(ContentLevel);
        }

        private void RaiseNavigateToString(string html, Uri url)
        {
            if (NavigateToString != null)
            {
                NavigateToString(this, new NavigateToStringEventArgs(html, url));
            }
        }

        public void BeginLoad(Uri url)
        {
            _pageService.BeginGetPage(url);
        }

        private ContentLevel _contentLevel;
        public ContentLevel ContentLevel
        {
            get { return _contentLevel; }
            set
            {
                if (_contentLevel == value) return;

                _contentLevel = value;
                RaisePropertyChanged("ContentLevel");
            }
        }

        public RelayCommand<ContentLevel> ContentLevelCommand { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Article { get; set; }

        public Uri  Original { get; set; }

        // TODO: replace with messaging
        public event EventHandler<NavigateToStringEventArgs> NavigateToString;
    }
}
