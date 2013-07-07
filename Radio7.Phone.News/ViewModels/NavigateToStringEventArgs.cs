using System;

namespace Radio7.Phone.News.ViewModels
{
    public class NavigateToStringEventArgs : EventArgs
    {
        public NavigateToStringEventArgs(string content, Uri url)
        {
            Content = content;
            Url = url;
        }

        public string Content { get; set; }

        public Uri Url { get; set; }
    }
}

