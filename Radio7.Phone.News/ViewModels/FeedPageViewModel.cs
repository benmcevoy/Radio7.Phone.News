using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Media;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Phone.Controls;
using Radio7.Phone.News.Infrastructure;
using Radio7.Phone.News.Models;
using Rss.Manager;
using Radio7.Phone.News.Data;

namespace Radio7.Phone.News.ViewModels
{
    public class FeedPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly TopicRepository _topicRepository;
        private Feed _feed;

        public FeedPageViewModel(INavigationService navigationService, TopicRepository topicRepository)
        {
            _navigationService = navigationService;
            _topicRepository = topicRepository;

            LaunchCommand = new RelayCommand<Uri>(Launch);
            NewsItems = Enumerable.Empty<NewsItem>();
        }

        public void Load(int id)
        {
            var topic = _topicRepository.Get(id);

            Title = topic.Title;
            Url = topic.Url;
            Size = topic.Size;
            AccentBrush = topic.AccentBrush;
            Image = topic.Image;

            WithDispatcher(() =>
                {
                    RaisePropertyChanged("Title");
                    RaisePropertyChanged("Url");
                    RaisePropertyChanged("Size");
                    RaisePropertyChanged("AccentBrush");
                    RaisePropertyChanged("Image");
                });

            _feed = new Feed(topic.Url);
            _feed.FeedLoaded += OnFeedLoaded;
            _feed.GetItemsFromWeb();
        }

        private void OnFeedLoaded(object sender, EventArgs e)
        {
            Debug.WriteLine("feed loaded " + Title);

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

            WithDispatcher(() => RaisePropertyChanged("NewsItems"));
        }

        private void Launch(Uri uri)
        {
            var url = uri.ToString();

            const string splitOn = "&amp;url=";
            var startIndex = url.IndexOf(splitOn, StringComparison.Ordinal);

            if (startIndex > -1)
            {
                url = url.Substring(startIndex + splitOn.Length);
            }

            _navigationService.NavigateTo(new Uri("/Views/ItemPage.xaml?url=" + HttpUtility.UrlEncode(url), UriKind.Relative));
        }

        public string Image { get; set; }

        public string Title { get; set; }

        public Uri Url { get; set; }

        public bool IsActive { get; set; }

        public int Index { get; set; }

        public IEnumerable<NewsItem> NewsItems { get; set; }

        public TileSize Size { get; set; }

        public SolidColorBrush AccentBrush { get; set; }

        public RelayCommand<Uri> LaunchCommand { get; set; }

        public static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}
