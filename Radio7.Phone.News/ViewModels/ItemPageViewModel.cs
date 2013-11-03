using System.Net;
using System.Windows;
using GalaSoft.MvvmLight;
using System;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services;

namespace Radio7.Phone.News.ViewModels
{
    public class ItemPageViewModel : ViewModelBase
    {
        private readonly IPageService _pageService;
        private readonly INavigationService _navigationService;
        private readonly IStateService _stateService;
        private readonly IMessenger _messenger;

        public ItemPageViewModel(IPageService pageService, INavigationService navigationService, IStateService stateService, IMessenger messenger)
        {
            _pageService = pageService;
            _navigationService = navigationService;
            _stateService = stateService;
            _messenger = messenger;
            _pageService.GetPageComplete += PageServiceOnGetPageComplete;

            DownloadArticleCommand = new RelayCommand<Uri>(BeginLoad);
            ViewOriginalCommand = new RelayCommand<Uri>(ViewOriginal);
            ViewCommentsCommand = new RelayCommand<RelatedNewsItem>(ViewComments);
        }

        public void BeginLoad(Uri url)
        {
            Original = url;
            _pageService.BeginGetPage(url);
        }

        public void ViewOriginal(Uri url)
        {
            _messenger.Send(new NavigateToStringMessage("", Original));
        }

        public void ViewComments(RelatedNewsItem newsItem)
        {
            if (newsItem == null) return;

            _stateService.CurrentItem = newsItem;

            _navigationService.NavigateTo(
                new Uri("/Views/Comments.xaml?url=" + HttpUtility.HtmlEncode(newsItem.Url.ToString()), 
                    UriKind.Relative), true);
        }

        public void CreatePage(string title, string html, Uri url)
        {
            Original = url;

            var page = _pageService.CreatePage(title, html, url);
            _messenger.Send(new NavigateToStringMessage(page, url));
        }

        private void PageServiceOnGetPageComplete(object sender, GetPageCompleteEventArgs getPageCompleteEventArgs)
        {
            WithDispatcher(() =>
            {
                Title = getPageCompleteEventArgs.Title;
                Article = getPageCompleteEventArgs.Html;
                Original = getPageCompleteEventArgs.Url;

                _messenger.Send(new NavigateToStringMessage(Article, Original));
            });
        }

        public RelayCommand<Uri> DownloadArticleCommand { get; set; }

        public RelayCommand<Uri> ViewOriginalCommand { get; set; }

        public RelayCommand<RelatedNewsItem> ViewCommentsCommand { get; set; }

        public string Title { get; set; }

        public string Article { get; set; }

        public RelatedNewsItem CommentsNewsItem { get; set; }

        private Uri _original;
        public Uri Original { get { return _original; } set { _original = value; RaisePropertyChanged("Original"); } }

        private static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}

