using System.IO;
using System.Reflection;
using Radio7.Phone.HtmlCleaner.Extractors.Content;
using System;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Radio7.Phone.HtmlCleaner.Extractors.Title;
using Radio7.Portable.OpenTextSummarizer;

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
            original.Navigate(address.Text);

            var webRequest = (HttpWebRequest)WebRequest.Create(address.Text);

            webRequest.CookieContainer = new CookieContainer();

            var webResponse = webRequest.GetResponse();

            using (var stream = webResponse.GetResponseStream())
            {
                var reader = new StreamReader(stream, Encoding.UTF8);
                var html = reader.ReadToEnd();
                var ce = new ContentExtractor();
                var clean = ce.Extract(html, new Uri(address.Text));
                var wrappedHtml  = WrapWithStyle(clean.Title, clean.Html);

                readable.NavigateToString(wrappedHtml);

                var summaryDoc = Summarizer.Summarize(new SummarizerArguments()
                    {
                        InputString = clean.Text
                    });

                summary.Text = "";

                foreach (var sentance in summaryDoc.Sentences)
                {
                    summary.Text += sentance.Trim() + Environment.NewLine + Environment.NewLine;
                }

                summary.Text += Environment.NewLine + "---------------------" + Environment.NewLine;

                foreach (var concept in summaryDoc.Concepts)
                {
                    summary.Text += concept + Environment.NewLine;
                }
            }
        }

        private string WrapWithStyle(string title, string clean)
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
