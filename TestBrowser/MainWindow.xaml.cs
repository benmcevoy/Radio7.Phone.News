using System.IO;
using System.Reflection;
using Radio7.Phone.HtmlCleaner.Extractors.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Radio7.Phone.HtmlCleaner.Extractors.Title;

namespace TestBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += (sender, args) =>
                {
                    original.Navigated += (a, b) => HideScriptErrors(original, true);
                };

        }

        public void HideScriptErrors(WebBrowser wb, bool hide)
        {
            FieldInfo fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;
            object objComWebBrowser = fiComWebBrowser.GetValue(wb);
            if (objComWebBrowser == null) return;
            objComWebBrowser.GetType().InvokeMember("Silent", BindingFlags.SetProperty, null, objComWebBrowser, new object[] { hide });
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            //var hasLoaded = false;

            //original.LoadCompleted += (o, args) =>
            //    {
            //        if (hasLoaded) return;

            //        var htmlDocument = (mshtml.HTMLDocument)original.Document;
            //        var html = htmlDocument.documentElement.outerHTML;
            //        hasLoaded = true;
            //        var ce = new ContentExtractor();
            //        var clean = ce.Extract(html);
            //        var te = new TitleExtractor();
            //        var title = te.Extract(html);
            //        clean = wrapwithstyle(title, clean);

            //        readable.NavigateToString(clean);
            //    };

            original.Navigate(address.Text);

            //using (var wc = new WebClient())
            //{
                
            //    var html = wc.DownloadString(address.Text);

            //    var ce = new ContentExtractor();
            //    var clean = ce.Extract(html);

            //    readable.NavigateToString(clean);
            //}

            var webRequest = (HttpWebRequest)WebRequest.Create(address.Text);
            
            webRequest.CookieContainer = new CookieContainer();
            
            var webResponse = webRequest.GetResponse();

            
            using (var stream = webResponse.GetResponseStream())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                var html = reader.ReadToEnd();
                var ce = new ContentExtractor();
                var clean = ce.Extract(html);
                var te = new TitleExtractor();
                var title = te.Extract(html);
                
                clean = wrapwithstyle(title, clean);
                readable.NavigateToString(clean);
            }
        }

        private string wrapwithstyle(string title, string clean)
        {
            var style = @"<style type='text/css'>

html, body, div, p { font-family: Arial; margin : 12px; }
p { font-size: 0.9em;}
figure, img, figcaption { display: block;}
figcaption { font-style: italic; font-size: 0.8em; }
img {width: 100%; max-width: 440px;}

</style>";

            return string.Format("{0}<h1>{1}</h1>{2}", style, title, clean);
        }
    }
}
