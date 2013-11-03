using System.Collections.Generic;
using Radio7.Phone.News.Data;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.ViewModels
{
    public class ListFeedsPageViewModel
    {
        private readonly TopicRepository _topicRepository;

        public ListFeedsPageViewModel(TopicRepository topicRepository)
        {
            _topicRepository = topicRepository;

            Topics = _topicRepository.Get();
        }

        public IEnumerable<Topic> Topics { get; set; }
    }
}
