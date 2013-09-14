using System.Collections.Generic;
using Radio7.Phone.News.Models;
using Microsoft.Phone.Shell;

namespace Radio7.Phone.News.Services
{
    public class StateService : IStateService
    {
        private const string CurrentItemKey = "CurrentItem";
        private IDictionary<string, object> State { get { return PhoneApplicationService.Current.State; } }

        public NewsItem CurrentItem
        {
            get { return Get<NewsItem>(CurrentItemKey); }
            set { Set(CurrentItemKey, value); }
        }

        public void Set<T>(string key, T value)
        {
            State[key] = value;
        }

        public T Get<T>(string key)
        {
            return State.ContainsKey(key) ?
                (T)State[key] :
                default(T);
        }
    }
}
