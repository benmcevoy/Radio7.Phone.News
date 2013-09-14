using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.Services
{
    public interface IStateService
    {
        NewsItem CurrentItem { get; set; }

        void Set<T>(string key, T value);

        T Get<T>(string key);
    }
}
