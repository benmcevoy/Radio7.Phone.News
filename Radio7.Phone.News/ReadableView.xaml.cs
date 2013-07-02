using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Radio7.Phone.HtmlCleaner.Extractors.Content;
using Radio7.Phone.HtmlCleaner.Extractors.Title;

namespace Radio7.Phone.News
{
    public partial class ReadableView : PhoneApplicationPage
    {
        private string _url;

        public ReadableView()
        {
            InitializeComponent();

            Browser.LoadCompleted += (sender, args) =>
                {
                    Browser.OpacityMask = null;
                    Browser.Opacity = 1;
                };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _url = "";

            if (NavigationContext.QueryString.ContainsKey("Url"))
            {
                _url = HttpUtility.UrlDecode(NavigationContext.QueryString["Url"]);
            }

            if (!string.IsNullOrEmpty(_url))
            {
                Load(_url);
            }

            SetMessage(this,"loading...");

            base.OnNavigatedTo(e);
        }

        public void Load(string url)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.CookieContainer = new CookieContainer();

            webRequest.BeginGetResponse(OnLoad, webRequest);
        }

        private void OnLoad(IAsyncResult ar)
        {
            var request = ((HttpWebRequest)ar.AsyncState);

            using (var response = request.EndGetResponse(ar))
            {
                using (var stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    var html = reader.ReadToEnd();
                    var ce = new ContentExtractor();
                    var clean = ce.Extract(html);
                    var te = new TitleExtractor();
                    var title = te.Extract(html);

                    clean = WrapWithStyle(_url, title, clean);

                    WithDispatcher(() =>
                        {
                            Browser.NavigateToString(clean);
                            ClearMessage(this);
                        });
                }
            }
        }

        private string WrapWithStyle(string url, string title, string clean)
        {
            const string style = @"<style type='text/css'>

html, body { font-size: 1em; font-family: 'Segoe WP', Arial; margin : 14px; background: black; color: white; font-weight: 400; }
h1 { font-size: 1.1em; font-weight: 400; text-transform: uppercase;}

a {color: yellow;font-weight: 400;}
p, div, ul, dl { font-weight: 400; margin : 56px 0px;}
figure, img, figcaption { display: block;}
figure, figcaption { font-style: italic; font-weight: 400; font-size: 0.9em; color: #ccc; }
img { width: 100%; max-width: 440px;}

</style>";

            return string.Format("<h3><a href='{0}'>View original article</a><h3>{1}<h1>{2}</h1>{3}", url, style, title, clean);
        }


        public static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }

        public static void SetMessage(DependencyObject sender, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            var progress = new ProgressIndicator
            {
                IsVisible = true,
                IsIndeterminate = true,
                Value = 0,
                Text = message
            };

            SystemTray.SetProgressIndicator(sender, progress);
        }

        public static void ClearMessage(DependencyObject sender)
        {
            SystemTray.SetProgressIndicator(sender, null);
        }
    }
}