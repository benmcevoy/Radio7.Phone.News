using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Radio7.Phone.HtmlCleaner;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services;
using Radio7.Phone.News.Data;
using System.Net;

namespace Radio7.Phone.News.ViewModels
{
    public class FeedPageViewModel : ViewModelBase
    {
        private readonly INewsService _newsService;
        private readonly INavigationService _navigationService;
        private readonly TopicRepository _topicRepository;
        private readonly IStateService _stateService;

        public FeedPageViewModel(INewsService newsService, INavigationService navigationService, 
            TopicRepository topicRepository, IStateService stateService)
        {
            _newsService = newsService;
            _navigationService = navigationService;
            _topicRepository = topicRepository;
            _stateService = stateService;

            _newsService.GetNewsComplete += NewsServiceOnGetNewsComplete;

            LaunchCommand = new RelayCommand<NewsItem>(Launch);
            NewsItems = Enumerable.Empty<NewsItem>();
        }

        private void NewsServiceOnGetNewsComplete(object sender, GetNewsCompleteEventArgs getNewsCompleteEventArgs)
        {
            NewsItems = getNewsCompleteEventArgs.NewsItems;

            WithDispatcher(() => RaisePropertyChanged("NewsItems"));
        }

        public void Refresh()
        {
            _newsService.BeginGetNews(Topic.Url, true);
        }

        public void Load(int topicId)
        {
            Topic = _topicRepository.Get(topicId);

            WithDispatcher(() => RaisePropertyChanged("Topic"));

            _newsService.BeginGetNews(Topic.Url, false);
        }

        private void Launch(NewsItem newsItem)
        {
            const string splitOn = "&url=";
            var url = newsItem.Url.ToString().Decode();
            var startIndex = url.LastIndexOf(splitOn, StringComparison.Ordinal);

            if (startIndex > -1)
            {
                url = url.Substring(startIndex + splitOn.Length);
            }

            _stateService.CurrentItem = newsItem;

            if (newsItem is RelatedNewsItem)
            {
                if ((newsItem as RelatedNewsItem).IsComment)
                {
                    _navigationService.NavigateTo(new Uri("/Views/Comments.xaml?url=" + HttpUtility.HtmlEncode(url),
                        UriKind.Relative));
                    return;
                }
            }

            _navigationService.NavigateTo(new Uri("/Views/ItemPage.xaml?url=" + HttpUtility.HtmlEncode(url), UriKind.Relative));
        }

        public Topic Topic { get; set; }

        public IEnumerable<NewsItem> NewsItems { get; set; }

        public RelayCommand<NewsItem> LaunchCommand { get; set; }

        private static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}
