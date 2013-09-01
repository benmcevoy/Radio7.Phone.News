﻿using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Data;
using Radio7.Phone.News.Services;
using Radio7.Phone.News.ViewModels;

namespace Radio7.Phone.News.Infrastructure
{
    public class ViewModelLocator
    {
        private readonly static INavigationService NavigationService = new NavigationService();
        private readonly static TopicRepository TopicRepository = new TopicRepository();
        private readonly static HtmlRepository HtmlRepository = new HtmlRepository();
        private readonly static IPageService PageService = new PageService(HtmlRepository, Messenger.Default);
        private readonly static INewsService NewsService = new NewsService(Messenger.Default);

        public HomePageViewModel HomePageViewModel { get { return new HomePageViewModel(NavigationService, TopicRepository); } }

        public FeedPageViewModel FeedPageViewModel { get { return new FeedPageViewModel(NewsService, NavigationService, TopicRepository); } }

        public ItemPageViewModel ItemPageViewModel { get { return new ItemPageViewModel(PageService, Messenger.Default); } }

        public AddFeedPageViewModel AddFeedPageViewModel { get { return new AddFeedPageViewModel(TopicRepository); } }
    }
}
