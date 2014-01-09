using System;
using System.Collections.Generic;

namespace Radio7.Phone.News.Infrastructure
{
    public class CacheProvider : ICacheProvider
    {
        private static readonly Dictionary<string, object> CacheStore = new Dictionary<string, object>(16);

        public T Get<T>(string key)
        {
            if (CacheStore.ContainsKey(key))
            {
                return (T)CacheStore[key];
            }

            return default(T);
        }

        public T Get<T>(string key, Func<T> valueResolver)
        {
            var temp = Get<T>(key);

            if (!temp.Equals(default(T))) return temp;

            temp = valueResolver();

            CacheStore[key] = temp;

            return temp;
        }

        public void Set(string key, object value)
        {
            CacheStore[key] = value;
        }
    }
}