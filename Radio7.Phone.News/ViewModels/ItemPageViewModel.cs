using System.Windows;
using GalaSoft.MvvmLight;
using System;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Services;

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

            DownloadArticleCommand = new RelayCommand<Uri>(BeginLoad);
            ViewOriginalCommand = new RelayCommand<Uri>(ViewOriginal);
            ViewCommentsCommand = new RelayCommand<object>(ViewComments);
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

        public void ViewComments(object todo)
        {
            // TODO:
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
                Summary = getPageCompleteEventArgs.Summary;
                Article = getPageCompleteEventArgs.Html;
                Original = getPageCompleteEventArgs.Url;

                _messenger.Send(new NavigateToStringMessage(Article, Original));
            });
        }

        public RelayCommand<Uri> DownloadArticleCommand { get; set; }

        public RelayCommand<Uri> ViewOriginalCommand { get; set; }

        public RelayCommand<object> ViewCommentsCommand { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Article { get; set; }

        private Uri _original;
        public Uri Original { get { return _original; } set { _original = value; RaisePropertyChanged("Original"); } }

        private static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}

