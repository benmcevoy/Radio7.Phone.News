using System;
using System.Net;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Services;
using Radio7.Phone.News.ViewModels;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.Views
{
    public partial class Comments : PhoneApplicationPage
    {
        private readonly IStateService _stateService = new StateService();

        public Comments()
        {
            InitializeComponent();

            Messenger.Default.Register<NavigateToStringMessage>(this, NavigateToString);

            Browser.Navigating += BrowserOnNavigating;

            Browser.LoadCompleted += (sender, args) =>
                {
                    Browser.OpacityMask = null;
                    Browser.Opacity = 1;
                };
        }

        private void NavigateToString(NavigateToStringMessage message)
        {
            WithDispatcher(() =>
            {
                if (string.IsNullOrEmpty(message.Content))
                {
                    Browser.Navigate(message.Url);
                }
                else
                {
                    var currentItem = _stateService.CurrentItem;

                    currentItem.Content = message.Content;

                    _stateService.CurrentItem = currentItem;

                    Browser.NavigateToString(message.Content);
                }
            });
        }

        private void BrowserOnNavigating(object sender, NavigatingEventArgs navigatingEventArgs)
        {
            navigatingEventArgs.Cancel = true;
            new WebBrowserTask { Uri = navigatingEventArgs.Uri }.Show();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string url;
            var currentItem = _stateService.CurrentItem as RelatedNewsItem;

            if (!NavigationContext.QueryString.TryGetValue("url", out url)) return;
            if (ViewModel == null) return;
            if (currentItem == null) return;

            ViewModel.Article = currentItem.Article;
            CommentTitle.Text = currentItem.CommentTitle.ToUpper();
            ViewModel.GetComments(new Uri(HttpUtility.HtmlDecode(url)));
        }

        private CommentsViewModel ViewModel
        {
            get { return Self.DataContext as CommentsViewModel; }
        }

        private void WebBrowser_OnScriptNotify(object sender, NotifyEventArgs e)
        {
            var thisBrowser = (WebBrowser)sender;
            var height = Convert.ToInt32(e.Value);
            var newHeight = height * 1.5D;

            thisBrowser.Height = newHeight;
        }

        private void ArticleButton_OnClick(object sender, EventArgs e)
        {
            ViewModel.ViewArticleCommand.Execute(ViewModel.Article);
        }

        private void ViewOriginalButton_OnClick(object sender, EventArgs e)
        {
            ViewModel.ViewOriginalCommand.Execute(ViewModel.Original);
        }

        private void WithDispatcher(Action action)
        {
            Dispatcher.BeginInvoke(action);
        }
    }
}