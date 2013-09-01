using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Radio7.Phone.News.Data;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services;

namespace Radio7.Phone.News.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly TopicRepository _topicRepository;
        
        public HomePageViewModel(INavigationService navigationService, TopicRepository topicRepository)
        {
            _navigationService = navigationService;
            _topicRepository = topicRepository;

            NavigateCommand = new RelayCommand<Topic>(Navigate);
            AddFeedCommand = new RelayCommand(AddFeed);
            ListFeedsCommand = new RelayCommand(ListFeeds);
            ChangeDisplayCommand = new RelayCommand(ChangeDisplaySettings);

            Topics = _topicRepository.Get();
        }

        private void Navigate(Topic topic)
        {
            _navigationService.NavigateTo(new Uri("/Views/FeedPage.xaml?id=" + topic.Index, UriKind.Relative));
        }

        private void AddFeed()
        {
            _navigationService.NavigateTo(new Uri("/Views/AddFeedPage.xaml", UriKind.Relative));
        }

        private void ListFeeds()
        {
            _navigationService.NavigateTo(new Uri("/Views/ListFeedsPage.xaml", UriKind.Relative));
        }

        private void ChangeDisplaySettings()
        {
            _navigationService.NavigateTo(new Uri("/Views/ChangeDisplaySettingsPage.xaml", UriKind.Relative));
        }

        public RelayCommand<Topic> NavigateCommand { get; set; }

        public RelayCommand AddFeedCommand { get; set; }

        public RelayCommand ListFeedsCommand { get; set; }

        public RelayCommand ChangeDisplayCommand { get; set; }

        public IEnumerable<Topic> Topics { get; set; }
    }
}

