using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;

namespace Radio7.Phone.News.Models
{
    public class Topic 
    {
        public Topic(string title, int index, Uri url, Color accentColor, string image)
        {
            NewsItems = Enumerable.Empty<NewsItem>();
            Title = title;
            Index = index;
            Url = url;
            Size = TileSize.Default;
            AccentBrush = new SolidColorBrush(accentColor);
            Image = image;
        }

        public string Image { get; set; }

        public string Title { get; set; }

        public Uri Url { get; set; }

        public bool IsActive { get; set; }

        public int Index { get; set; }

        public IEnumerable<NewsItem> NewsItems { get; set; }

        public TileSize Size { get; set; }

        public SolidColorBrush AccentBrush { get; set; }
    }
}
