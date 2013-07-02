using System;
using System.Collections.Generic;
using System.ComponentModel;
using Radio7.Phone.Common;
using System.Windows.Media;

namespace Radio7.Phone.News.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        //ned=au

        //n - news
        //b - business
        //m - health
        //snc - science
        //tc - technology
        //s - sport
        //w - world
        //e - entertainment
        //h - more top stories

        public MainViewModel()
        {
            Topics = new List<Topic>
                {
                    new Topic("top stories", 1, new Uri("http://news.google.com/?ned=au&output=rss", UriKind.Absolute), Color.FromArgb(255,229,20,0), "/Content/top.png"),
                    new Topic("business", 2, new Uri("http://news.google.com/?ned=au&topic=b&output=rss", UriKind.Absolute), Color.FromArgb(255,27,161,226), "/Content/business.png"),
                    new Topic("world", 3, new Uri("http://news.google.com/?ned=au&topic=w&output=rss", UriKind.Absolute), Color.FromArgb(255,164,196,0), "/Content/world.png"),
                    new Topic("australia", 4, new Uri("http://news.google.com/?ned=au&topic=n&output=rss", UriKind.Absolute), Color.FromArgb(255,250,104,0), "/Content/australia.png"),
                    new Topic("science", 5, new Uri("http://news.google.com/?ned=au&topic=snc&output=rss", UriKind.Absolute), Color.FromArgb(255,109,135,100), "/Content/science.png"),
                   // new Topic("technology", 6, new Uri("http://news.google.com/?ned=au&topic=tc&output=rss", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/technology.png")
                   //new Topic("conversation", 6, new Uri("http://theconversation.com/au/society/articles.atom", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/conversation.png"),
                   new Topic("hacker", 6, new Uri("https://news.ycombinator.com/rss", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/conversation.png"),
                   new Topic("/.", 7, new Uri("http://rss.slashdot.org/Slashdot/slashdot", UriKind.Absolute), Color.FromArgb(255,100,118,135), "/Content/conversation.png"),
                   //
                   //new Topic("xkcd", 6, new Uri("http://xkcd.com/rss.xml", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/conversation.png"),
                   //http://blog.benmcevoy.com.au/feed
                  // new Topic("me", 7, new Uri("http://blog.benmcevoy.com.au/feed", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/conversation.png"),
                };

            NavigateCommand = new DelegateCommand(Navigate, CanAlwaysExecute);
            SelectedIndex = 0;
            ChainWebCalls(Topics);
        }

        public void Load()
        {
            Topics[0].Load();
        }

        private void ChainWebCalls(List<Topic> topics)
        {
            var length = topics.Count - 1;

            for (var i = 0; i < length; i++)
            {
                var index = i;

                topics[i].FeedLoaded += (sender, args) =>
                    {
                        if (index + 1 > length)
                        {
                            return;
                        }

                        topics[index + 1].Load();
                    };
            }
        }

        private void Navigate(object obj)
        {
            var topic = (Topic)obj;

            SelectedIndex = topic.Index;

            OnPropertyChanged("SelectedIndex");
        }

        protected bool CanAlwaysExecute(object state)
        {
            return true;
        }

        public DelegateCommand NavigateCommand { get; set; }
        public int SelectedIndex { get; set; }
        public List<Topic> Topics { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

