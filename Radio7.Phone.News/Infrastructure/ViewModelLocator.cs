using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Data;
using Radio7.Phone.News.Services;
using Radio7.Phone.News.Services.Comments;
using Radio7.Phone.News.Services.RelatedNewsItems;
using Radio7.Phone.News.Services.Snippets;
using Radio7.Phone.News.ViewModels;
using Radio7.Portable.StrategyResolver;

namespace Radio7.Phone.News.Infrastructure
{
    public class ViewModelLocator
    {
        private readonly static IStateService StateService = new StateService();
        private readonly static INavigationService NavigationService = new NavigationService();
        private readonly static TopicRepository TopicRepository = new TopicRepository();
        private readonly static HtmlRepository HtmlRepository = new HtmlRepository();
        private readonly static IPageService PageService = new PageService(HtmlRepository, Messenger.Default);
        
        private readonly static INewsService NewsService = new NewsService(Messenger.Default, 
            new StrategyResolver<IRelatedNewsItemsParser>(), new StrategyResolver<ISnippetExtractor>());
        
        private readonly static ICommentService CommentService = new CommentService(Messenger.Default,
            new StrategyResolver<ICommentExtractor>(), HtmlRepository);

        public HomePageViewModel HomePageViewModel { get { return new HomePageViewModel(NavigationService, TopicRepository); } }
        
        public FeedPageViewModel FeedPageViewModel { get { return new FeedPageViewModel(NewsService, 
            NavigationService, TopicRepository, StateService); } }
        
        public ItemPageViewModel ItemPageViewModel { get { return new ItemPageViewModel(PageService, Messenger.Default); } }
        
        public AddFeedPageViewModel AddFeedPageViewModel { get { return new AddFeedPageViewModel(TopicRepository); } }
        
        public CommentsViewModel CommentsViewModel { get { return new CommentsViewModel(CommentService); } }
    }
}

