using System;
using System.Net;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.HtmlCleaner;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services;

namespace Radio7.Phone.News.ViewModels
{
    public class CommentsViewModel : ViewModelBase
    {
        private readonly ICommentService _commentService;
        private readonly INavigationService _navigationService;
        private readonly IStateService _stateService;
        private readonly IMessenger _messenger;

        public CommentsViewModel(ICommentService commentService, INavigationService navigationService, IStateService stateService, IMessenger messenger)
        {
            _commentService = commentService;
            _navigationService = navigationService;
            _stateService = stateService;
            _messenger = messenger;
            _commentService.GetCommentsComplete += CommentServiceOnGetCommentsComplete;

            ViewOriginalCommand = new RelayCommand<Uri>(ViewOriginal);
            ViewArticleCommand = new RelayCommand<NewsItem>(ViewArticle);
        }

        public void GetComments(Uri url)
        {
            Original = url;
            _commentService.BeginGetComments(url);
        }

        public void ViewOriginal(Uri url)
        {
            _messenger.Send(new NavigateToStringMessage("", Original));
        }

        public void ViewArticle(NewsItem newsItem)
        {
            if (newsItem == null) return;

            const string splitOn = "&url=";
            var url = newsItem.Url.ToString().Decode();
            var startIndex = url.LastIndexOf(splitOn, StringComparison.Ordinal);

            if (startIndex > -1)
            {
                url = url.Substring(startIndex + splitOn.Length);
            }

            _stateService.CurrentItem = newsItem;
            _navigationService.NavigateTo(new Uri("/Views/ItemPage.xaml?url=" + HttpUtility.HtmlEncode(url), UriKind.Relative), true);
        }

        private void CommentServiceOnGetCommentsComplete(object sender, GetCommentsCompleteEventArgs getCommentsCompleteEventArgs)
        {
            WithDispatcher(() =>
                {
                    Comments = getCommentsCompleteEventArgs.CommentsHtml;
                    RaisePropertyChanged("Comments");
                });
        }

        public string Comments { get; set; }

        public RelayCommand<Uri> ViewOriginalCommand { get; set; }

        public RelayCommand<NewsItem> ViewArticleCommand { get; set; }

        public NewsItem Article { get; set; }

        private Uri _original;
        public Uri Original { get { return _original; } set { _original = value; RaisePropertyChanged("Original"); } }

        public static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}
