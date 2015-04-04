using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.Data
{
    public class TopicRepository
    {
        public IEnumerable<Topic> Get()
        {
            //ned=au

            //n - news
            //b - business
            //m - health
            //snc - science
            //tc - technology
            //s - sport
            //w - world
            //e - entertainment
            //h - more top stories

            return Topics;
        }

        public Topic Get(int id)
        {
            return Topics.Single(t => t.Index == id);
        }

        private static readonly List<Topic> Topics = new List<Topic>
                {
                    new Topic("top stories", 1, new Uri("http://news.google.com/?ned=au&output=rss", UriKind.Absolute), Color.FromArgb(255,229,20,0), "/Content/top.png"),
                    new Topic("business", 2, new Uri("http://news.google.com/?ned=au&topic=b&output=rss", UriKind.Absolute), Color.FromArgb(255,27,161,226), "/Content/business.png"),
                    new Topic("world", 3, new Uri("http://news.google.com/?ned=au&topic=w&output=rss", UriKind.Absolute), Color.FromArgb(255,164,196,0), "/Content/world.png"),
                    new Topic("australia", 4, new Uri("http://news.google.com/?ned=au&topic=n&output=rss", UriKind.Absolute), Color.FromArgb(255,250,104,0), "/Content/australia.png"),
                    new Topic("science", 5, new Uri("http://news.google.com/?ned=au&topic=snc&output=rss", UriKind.Absolute), Color.FromArgb(255,109,135,100), "/Content/science.png"),
                    new Topic("conversation", 6, new Uri("http://theconversation.com/articles.atom", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/conversation.png"),
                    new Topic("guardian opinion", 7, new Uri("http://www.theguardian.com/au/commentisfree/rss", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/guardian.png"),
                    new Topic("the drum", 8, new Uri("http://www.abc.net.au/news/feed/1054578/rss.xml", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/drum.png"),
                   
                    // ben
                    new Topic("technology", 10, new Uri("http://news.google.com/?ned=au&topic=tc&output=rss", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/technology.png"),
                    new Topic("hacker news", 11, new Uri("https://news.ycombinator.com/rss", UriKind.Absolute), Color.FromArgb(255,0,80,239), "/Content/hacker.png"),
                    new Topic("slashdot", 12, new Uri("http://rss.slashdot.org/Slashdot/slashdot", UriKind.Absolute), Color.FromArgb(255,100,118,135), "/Content/slashdot.png"),
                    new Topic("bookmarks", 13, new Uri("http://benmcevoy.azurewebsites.net/bm/bm.ashx", UriKind.Absolute), Color.FromArgb(255,109,135,100), "/Content/bm.png"),
                    
                };
    }
}
