using System;
using System.Windows;
using GalaSoft.MvvmLight;
using Radio7.Phone.News.Services;

namespace Radio7.Phone.News.ViewModels
{
    public class CommentsViewModel : ViewModelBase
    {
        private readonly ICommentService _commentService;

        public CommentsViewModel(ICommentService commentService)
        {
            _commentService = commentService;
            _commentService.GetCommentsComplete += CommentServiceOnGetCommentsComplete;
        }

        public void GetComments(Uri url)
        {
            _commentService.BeginGetComments(url);
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

        public static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}
