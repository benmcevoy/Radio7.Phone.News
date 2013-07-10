using System;

namespace Radio7.Phone.News.Messages
{
    public class NavigateToStringMessage
    {
        public NavigateToStringMessage(string content, Uri url)
        {
            Content = content;
            Url = url;
        }

        public string Content { get; set; }

        public Uri Url { get; set; }
    }
}
