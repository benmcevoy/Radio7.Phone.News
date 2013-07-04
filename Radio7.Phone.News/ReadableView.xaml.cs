using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Radio7.Phone.HtmlCleaner.Extractors.Content;
using Radio7.Phone.HtmlCleaner.Extractors.Title;
using Radio7.Phone.Common.IO;

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

                    WithDispatcher(() =>
                        {
                            Browser.InvokeScript("eval",
                                                 "try{enablePrettyPrinting();}catch(e){}");
                        });
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

            SetMessage(this, "loading...");

            base.OnNavigatedTo(e);
        }

        public void Load(string url)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.CookieContainer = new CookieContainer();
            webRequest.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3";

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
                    var clean = ce.Extract(html, response.ResponseUri);
                    var te = new TitleExtractor();
                    var title = te.Extract(html);

                    clean = CreatePage(_url, title, clean);

                    WithDispatcher(() =>
                        {
                            Browser.NavigateToString(clean);
                            ClearMessage(this);
                        });
                }
            }
        }

        private static string _script;
        private static string GetScript()
        {
            if (string.IsNullOrEmpty(_script))
            {
                _script = ResourceHelper.LoadStringFromResource(new Uri("/Radio7.Phone.News;component/Content/Scripts/prettify.js", UriKind.Relative));
            }
            return _script;
        }

        private static string _style;
        private static string GetStyle()
        {
            if (string.IsNullOrEmpty(_style))
            {
                _style = ResourceHelper.LoadStringFromResource(new Uri("/Radio7.Phone.News;component/Content/Css/base.css", UriKind.Relative));
            }
            return _style;
        }

        private string CreatePage(string url, string title, string body)
        {
            const string wrapper = @"<meta name='Viewport' content='width=320; user-scaleable=yes; initial-scale=1.0' />
<style type='text/css'>{1}</style>
<script type'text/javascript'>{0}</script>
<h3><a href='{2}'>View original article</a><h3>
<h1>{3}</h1>
{4}";
                  
            return string.Format(wrapper, GetScript(), GetStyle(), url, title, body);
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