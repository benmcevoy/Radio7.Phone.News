using System;
using System.Linq;
using System.Net;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.ViewModels;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Services;

namespace Radio7.Phone.News.Views
{
    public partial class ItemPage : PhoneApplicationPage
    {
        private readonly IStateService _stateService = new StateService();

        public ItemPage()
        {
            InitializeComponent();

            Messenger.Default.Register<NavigateToStringMessage>(this, NavigateToString);

            Browser.Navigating += BrowserOnNavigating;

            Browser.LoadCompleted += (sender, args) =>
            {
                Browser.OpacityMask = null;
                Browser.Opacity = 1;

                Messenger.Default.Send(new NavigateToStringCompleteMessage());

                WithDispatcher(() =>
                    {
                        try
                        {
                            Browser.InvokeScript("eval",
                                                 "try{enablePrettyPrinting();}catch(e){}");
                        }
                        catch { }
                    });
            };
        }

        private void BrowserOnNavigating(object sender, NavigatingEventArgs navigatingEventArgs)
        {
            navigatingEventArgs.Cancel = true;
            new WebBrowserTask { Uri = navigatingEventArgs.Uri }.Show();
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
                        Browser.NavigateToString(message.Content);
                    }
                });
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // TODO:
            SetAppBarButtonEnabled("comments", false);

            string url;
            var currentItem = _stateService.CurrentItem;

            if (ViewModel == null) return;
            if (currentItem == null) return;
            if (!NavigationContext.QueryString.TryGetValue("url", out url)) return;

            if (string.IsNullOrEmpty(currentItem.Content))
            {
                SetAppBarButtonEnabled("download", false);

                ViewModel.BeginLoad(new Uri(HttpUtility.HtmlDecode(url)));
            }
            else
            {
                SetAppBarButtonEnabled("download", true);

                ViewModel.CreatePage(currentItem.Title,
                                     currentItem.Content,
                                     new Uri(HttpUtility.HtmlDecode(url)));
            }
        }

        private void SetAppBarButtonEnabled(string buttonText, bool isEnabled)
        {
            var button =
                ApplicationBar.Buttons.Cast<ApplicationBarIconButton>()
                              .FirstOrDefault(b => b.Text.ToLowerInvariant() == buttonText.ToLowerInvariant());

            if (button != null)
            {
                button.IsEnabled = isEnabled;
            }
        }

        private ItemPageViewModel ViewModel
        {
            get { return Self.DataContext as ItemPageViewModel; }
        }

        private void DownloadButton_OnClick(object sender, EventArgs e)
        {
            ViewModel.DownloadArticleCommand.Execute(ViewModel.Original);
        }

        private void ViewOriginalButton_OnClick(object sender, EventArgs e)
        {
            ViewModel.ViewOriginalCommand.Execute(ViewModel.Original);
        }

        private void CommentsButton_OnClick(object sender, EventArgs e)
        {
            // TODO:
            ViewModel.ViewCommentsCommand.Execute(null);
        }

        private void WithDispatcher(Action action)
        {
            Dispatcher.BeginInvoke(action);
        }
    }
}