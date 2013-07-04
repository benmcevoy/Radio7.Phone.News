﻿using Radio7.Phone.News.Data;
using Radio7.Phone.News.Services;
using Radio7.Phone.News.ViewModels;

namespace Radio7.Phone.News.Infrastructure
{
    public class ViewModelLocator
    {
        private readonly static INavigationService NavigationService = new NavigationService();
        private readonly static TopicRepository TopicRepository = new TopicRepository();
        private readonly static HtmlRepository HtmlRepository = new HtmlRepository();
        private readonly static PageService PageService = new PageService(HtmlRepository);

        public HomePageViewModel HomePageViewModel { get { return new HomePageViewModel(NavigationService, TopicRepository); } }

        public FeedPageViewModel FeedPageViewModel { get { return new FeedPageViewModel(NavigationService, TopicRepository); } }

        public ItemPageViewModel ItemPageViewModel { get { return new ItemPageViewModel(PageService); } }
    }
}
