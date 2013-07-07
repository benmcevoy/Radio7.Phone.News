using System;
using System.Collections.Generic;

namespace Radio7.Phone.News.Services
{
    public class GetPageCompleteEventArgs : EventArgs
    {
        public GetPageCompleteEventArgs(Uri url, string title, string text, string summary, IEnumerable<string> keywords, string html)
        {
            Url = url;
            Title = title;
            Text = text;
            Summary = summary;
            Keywords = keywords;
            Html = html;
        }

        public Uri Url { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Summary { get; set; }

        public IEnumerable<string> Keywords { get; set; }

        public string Html { get; set; }
    }
}