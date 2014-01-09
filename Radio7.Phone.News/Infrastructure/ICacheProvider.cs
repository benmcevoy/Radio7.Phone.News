using System;

namespace Radio7.Phone.News.Infrastructure
{
    public interface ICacheProvider
    {
        T Get<T>(string key);

        T Get<T>(string key, Func<T> resolver);

        void Set(string key, object value);
    }
}
