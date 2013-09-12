using Microsoft.Phone.Controls;
using System.Windows;

namespace Radio7.Phone.News.Views
{
    public static class WebBrowserAttachedProperties
    {
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
                    "Html", 
                    typeof(string), 
                    typeof(WebBrowserAttachedProperties), 
                    new PropertyMetadata(OnHtmlChanged));

        public static string GetHtml(DependencyObject dependencyObject)
        {
            return (string)dependencyObject.GetValue(HtmlProperty);
        }

        public static void SetHtml(DependencyObject dependencyObject, string value)
        {
            dependencyObject.SetValue(HtmlProperty, value);
        }

        private static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var browser = dependencyObject as WebBrowser;

            if (browser == null) return;

            var html = dependencyPropertyChangedEventArgs.NewValue.ToString();

            browser.NavigateToString(html);
        }
    }
}
