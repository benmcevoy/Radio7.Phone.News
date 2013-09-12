using System;
using System.Net;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.ViewModels;
using GalaSoft.MvvmLight.Messaging;

namespace Radio7.Phone.News.Views
{
    public partial class ItemPage : PhoneApplicationPage
    {
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

            string url;

            if (ViewModel == null) return;
            if (!NavigationContext.QueryString.TryGetValue("url", out url)) return;

            if (string.IsNullOrEmpty(FeedPageViewModel.CurrentItem.Content))
            {
                ViewModel.BeginLoad(new Uri(HttpUtility.HtmlDecode(url)));
            }
            else
            {
                ViewModel.CreatePage(FeedPageViewModel.CurrentItem.Title,
                                     FeedPageViewModel.CurrentItem.Content,
                                     new Uri(HttpUtility.HtmlDecode(url)));
            }
        }

        private ItemPageViewModel ViewModel
        {
            get { return Self.DataContext as ItemPageViewModel; }
        }

        private void WithDispatcher(Action action)
        {
            Dispatcher.BeginInvoke(action);
        }
    }
}