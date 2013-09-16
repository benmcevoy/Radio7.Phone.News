using System;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services;

namespace Radio7.Phone.News.ViewModels
{
    public class CommentsViewModel : ViewModelBase
    {
        private readonly ICommentService _commentService;
        private readonly IMessenger _messenger;

        public CommentsViewModel(ICommentService commentService, IMessenger messenger)
        {
            _commentService = commentService;
            _messenger = messenger;
            _commentService.GetCommentsComplete += CommentServiceOnGetCommentsComplete;

            ViewOriginalCommand = new RelayCommand<Uri>(ViewOriginal);
            ViewArticleCommand = new RelayCommand<object>(ViewArticle);
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

        public void ViewArticle(object todo)
        {
            // TODO:
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

        public RelayCommand<object> ViewArticleCommand { get; set; }

        private Uri _original;
        public Uri Original { get { return _original; } set { _original = value; RaisePropertyChanged("Original"); } }

        public static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}
