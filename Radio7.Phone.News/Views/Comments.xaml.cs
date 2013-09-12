using System;
using System.Net;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using Radio7.Phone.News.ViewModels;

namespace Radio7.Phone.News.Views
{
    public partial class Comments : PhoneApplicationPage
    {
        public Comments()
        {
            InitializeComponent();

            Browser.Navigating += BrowserOnNavigating;
        }

        private void BrowserOnNavigating(object sender, NavigatingEventArgs navigatingEventArgs)
        {
            navigatingEventArgs.Cancel = true;
            new WebBrowserTask { Uri = navigatingEventArgs.Uri }.Show();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Browser.NavigateToString("");

            string url;

            if (!NavigationContext.QueryString.TryGetValue("url", out url)) return;

            if (ViewModel != null) ViewModel.GetComments(new Uri(HttpUtility.HtmlDecode(url)));
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
    }
}