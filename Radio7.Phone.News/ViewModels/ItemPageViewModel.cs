using GalaSoft.MvvmLight;
using System;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Services;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.ViewModels
{
    public class ItemPageViewModel : ViewModelBase
    {
        private readonly IPageService _pageService;
        private readonly IMessenger _messenger;

        public ItemPageViewModel(IPageService pageService, IMessenger messenger)
        {
            _pageService = pageService;
            _messenger = messenger;
            _pageService.GetPageComplete += PageServiceOnGetPageComplete;

            ContentLevelCommand = new RelayCommand<string>(SetContentLevel);
        }

        private void SetContentLevel(string contentLevel)
        {
            var level = (ContentLevel)Enum.Parse(ContentLevel.GetType(), contentLevel, true);

            ContentLevel = level;

            switch (level)
            {
                case ContentLevel.Summary:
                    _messenger.Send(new NavigateToStringMessage(Summary, Original));
                    break;
                case ContentLevel.Article:
                    _messenger.Send(new NavigateToStringMessage(Article, Original));
                    break;
                case ContentLevel.Original:
                    _messenger.Send(new NavigateToStringMessage("", Original));
                    break;
            }
        }

        private void PageServiceOnGetPageComplete(object sender, GetPageCompleteEventArgs getPageCompleteEventArgs)
        {
            Title = getPageCompleteEventArgs.Title;
            Summary = getPageCompleteEventArgs.Summary;
            Article = getPageCompleteEventArgs.Html;
            Original = getPageCompleteEventArgs.Url;

            SetContentLevel(ContentLevel.ToString());
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

        public RelayCommand<string> ContentLevelCommand { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Article { get; set; }

        public Uri Original { get; set; }

        public void LoadNextView()
        {
            var contentLevel = ((int)ContentLevel);

            contentLevel++;

            if (contentLevel > 2) return;

            var newContentLevel = (ContentLevel)contentLevel;

            SetContentLevel(newContentLevel.ToString());
        }

        public void LoadPreviousView()
        {
            var contentLevel = ((int)ContentLevel);

            contentLevel--;

            if (contentLevel < 0) return;

            var newContentLevel = (ContentLevel)contentLevel;

            SetContentLevel(newContentLevel.ToString());
        }
    }
}
