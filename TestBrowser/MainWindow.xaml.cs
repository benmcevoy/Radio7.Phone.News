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
            var fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;
            var objComWebBrowser = fiComWebBrowser.GetValue(wb);
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
                
                summary.Text = clean.Summary;
                summary.Text += Environment.NewLine + "---------------------" + Environment.NewLine;

                foreach (var concept in clean.Keywords)
                {
                    summary.Text += concept + Environment.NewLine;
                }
            }
        }

        private string WrapWithStyle(string title, string clean)
        {
            var style = @"<!DOCTYPE html>
<html>
<head>
    <title>-</title>
    <meta charset=""utf-8"" />
<style type='text/css'>{2}</style></head>
    <body>
<h1>{0}</h1>
<div>{1}</div></body></html>";

            return string.Format(style, title, clean, @"html, body, div, p { font-family: Arial; margin : 12px; }
p { font-size: 0.9em;}
figure, img, figcaption { display: block;}
figcaption { font-style: italic; font-size: 0.8em; }
img {width: 100%; max-width: 440px;}");
        }
    }
}
