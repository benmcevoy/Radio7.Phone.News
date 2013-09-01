using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using Radio7.Phone.News.Data;

namespace Radio7.Phone.News.ViewModels
{
    public class AddFeedPageViewModel : ViewModelBase
    {
        private readonly TopicRepository _topicRepository;

        public AddFeedPageViewModel(TopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }

        public string FeedUrl { get; set; }
    }
}
