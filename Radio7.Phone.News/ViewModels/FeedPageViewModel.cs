using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Radio7.Phone.News.Infrastructure;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services;
using Radio7.Phone.News.Data;

namespace Radio7.Phone.News.ViewModels
{
    public class FeedPageViewModel : ViewModelBase
    {
        private readonly INewsService _newsService;
        private readonly INavigationService _navigationService;
        private readonly TopicRepository _topicRepository;

        public FeedPageViewModel(INewsService newsService, INavigationService navigationService, TopicRepository topicRepository)
        {
            _newsService = newsService;
            _navigationService = navigationService;
            _topicRepository = topicRepository;

            _newsService.GetNewsComplete += NewsServiceOnGetNewsComplete;

            LaunchCommand = new RelayCommand<Uri>(Launch);
            NewsItems = Enumerable.Empty<NewsItem>();
        }

        private void NewsServiceOnGetNewsComplete(object sender, GetNewsCompleteEventArgs getNewsCompleteEventArgs)
        {
            // TODO: raise progress message
            ProgressHelper.ClearMessage();
            NewsItems = getNewsCompleteEventArgs.NewsItems;
            WithDispatcher(() => RaisePropertyChanged("NewsItems"));
        }

        public void Load(int id)
        {
            Topic = _topicRepository.Get(id);

            WithDispatcher(() => RaisePropertyChanged("Topic"));

            // TODO: raise progress message
            ProgressHelper.SetMessage(" ");

            _newsService.BeginGetNews(Topic.Url);
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

        public Topic Topic { get; set; }

        public IEnumerable<NewsItem> NewsItems { get; set; }

        public RelayCommand<Uri> LaunchCommand { get; set; }

        public static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}
