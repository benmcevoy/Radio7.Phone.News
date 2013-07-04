using System;
using System.Collections.Generic;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.Services
{
    public class GetNewsCompleteEventArgs : EventArgs
    {
        public GetNewsCompleteEventArgs(IEnumerable<NewsItem> newsItems)
        {
            NewsItems = newsItems;
        }

        public IEnumerable<NewsItem> NewsItems{ get; private set; }
    }
}
