using System;

namespace Radio7.Phone.News.ViewModels
{
    public class NavigateToStringEventArgs : EventArgs
    {
        public NavigateToStringEventArgs(string content)
        {
            Content = content;
        }

        public string Content { get; set; }
    }
}