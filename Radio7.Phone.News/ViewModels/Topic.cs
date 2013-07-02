using System.Diagnostics;
using System.Net;
using System.Windows;
using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Media;
using Microsoft.Phone.Tasks;
using Radio7.Phone.Common;
using Rss.Manager;
using System.ComponentModel;
using System.Linq;

namespace Radio7.Phone.News.ViewModels
{
    public class Topic : INotifyPropertyChanged
    {
        private readonly Feed _feed;

        public Topic(string title, int index, Uri url, Color accentColor, string image)
        {
            LaunchCommand = new DelegateCommand(Launch, CanAlwaysExecute);
            NewsItems = Enumerable.Empty<NewsItem>();
            Title = title;
            Index = index;
            Url = url;
            Size = TileSize.Default;
            AccentBrush = new SolidColorBrush(accentColor);
            Image = image;

            _feed = new Feed(Url);
            _feed.FeedLoaded += OnFeedLoaded;
        }

        public void Load()
        {
            _feed.GetItemsFromWeb();
        }

        private void OnFeedLoaded(object sender, EventArgs e)
        {
            Debug.WriteLine("feed loaded " + Index);
            WithDispatcher(() =>
                {
                    NewsItems = _feed.Items.Select(i => new NewsItem
                        {
                            Title = i.Title,
                            Url = new Uri(i.Id, UriKind.Absolute),
                            Snippet = i.Snippet,
                            RelatedNewsItems = RelatedLinksParser.GetRelatedLinks(i.Content).Select(r => new RelatedNewsItem
                                {
                                    Title = r.Title,
                                    Url = new Uri(r.Link, UriKind.Absolute)
                                }).ToList()
                        });

                    OnPropertyChanged("NewsItems");

                    if (FeedLoaded != null)
                    {
                        FeedLoaded(this, EventArgs.Empty);
                    }
                });
        }

        private void Launch(object obj)
        {
            var item = (Uri)obj;

            var url = item.ToString();
            var splitOn = "&amp;url=";
            var startIndex = url.IndexOf(splitOn);

            if (startIndex > -1)
            {
                url = url.Substring(startIndex + splitOn.Length);
            }

            var rootFrame = (App.Current as App).RootFrame;
            //
            rootFrame.Navigate(new Uri("/ReadableView.xaml?Url=" + HttpUtility.UrlEncode(url), UriKind.Relative));


            //try
            //{
            //    var webBrowserTask = new WebBrowserTask { Uri = item };

            //    webBrowserTask.Show();
            //}
            //catch (Exception)
            //{

            //}
        }

        protected bool CanAlwaysExecute(object state)
        {
            return true;
        }

        public string Image { get; set; }

        public string Title { get; set; }

        public Uri Url { get; set; }

        public bool IsActive { get; set; }

        public int Index { get; set; }

        public IEnumerable<NewsItem> NewsItems { get; set; }

        public TileSize Size { get; set; }

        public SolidColorBrush AccentBrush { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand LaunchCommand { get; set; }

        public event EventHandler FeedLoaded;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}
