using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace Rss.Manager
{
    public class Feed
    {
        private readonly XNamespace _atomNamespace = "http://www.w3.org/2005/Atom";
        private readonly XNamespace _purlNamespace = "http://purl.org/rss/1.0/modules/content/";

        public Feed(Uri feedUri)
        {
            FeedUri = feedUri;
            Items = new List<Item>();
            HtmlUri = feedUri;
        }

        public Feed(Uri feedUri, string title, Uri htmlUri)
        {
            FeedUri = feedUri;
            Items = new List<Item>();
            Title = title;
            HtmlUri = htmlUri;
        }

        public void GetItemsFromWeb()
        {
            GetXml(FeedUri);
        }

        private void SetXml(XDocument xml)
        {
            if (xml.Root == null) return;

            Title = GetTitle(xml);

            switch (xml.Root.Name.LocalName.ToLower())
            {
                case "rss":
                    Items = GetRss(xml);
                    break;
                case "feed":
                    Items = GetAtom(xml);
                    break;
            }
        }

        private string GetTitle(XDocument xml)
        {
            try
            {
                if (xml.Root != null)
                {
                    switch (xml.Root.Name.LocalName.ToLower())
                    {
                        case "rss":
                            return xml.Element("rss").Element("channel")
                                .Element("title").Value;

                        case "feed":
                            return xml.Element("feed").Element("title").Value;
                    }
                }

                return "Can't find title";
            }
            catch
            {
                return "Can't find title";
            }
        }

        private List<Item> GetRss(XDocument xml)
        {
            var xElement4 = xml.Element("rss");
            if (xElement4 != null)
            {
                var channelElement = xElement4.Element("channel");

                if (channelElement != null && channelElement.Element("link") != null)
                {
                    var xElement = channelElement.Element("link");
                    if (xElement != null) BaseUrl = xElement.Value;
                }

                // check for the existance of content:encoded element and use that if we have any
                if (channelElement != null)
                {
                    var test = channelElement.Elements("item")
                                             .Descendants(_purlNamespace + "encoded");

                    if (test.Any())
                    {
                        return (from f in channelElement.Elements("item")
                                let link = f.Element("link")
                                where link != null
                                let encoded = f.Element(_purlNamespace + "encoded")
                                where encoded != null
                                let title = f.Element("title")
                                where title != null
                                let pubDate = f.Element("pubDate")
                                where pubDate != null
                                select new Item(link.Value,
                                                encoded.Value,
                                                HttpUtility.HtmlDecode(title.Value),
                                                pubDate.Value)).ToList();
                    }
                }

                if (channelElement != null)
                    return (from f in channelElement.Elements("item")
                            let link = f.Element("link")
                            where link != null
                            let description = f.Element("description")
                            where description != null
                            let title = f.Element("title")
                            where title != null
                            let pubDate = f.Element("pubDate")
                            where pubDate != null
                            select new Item(link.Value,
                                            description.Value,
                                           HttpUtility.HtmlDecode(title.Value),
                                            pubDate.Value)).ToList();
            }
            return null;
        }

        private List<Item> GetAtom(XDocument xml)
        {
            try
            {
                var xElement = xml.Element(_atomNamespace + "feed");
                if (xElement != null)
                {
                    var element = xElement.Element(_atomNamespace + "link");
                    if (element != null)
                        BaseUrl = element.Attribute("href").Value;
                }
            }
            catch { }

            bool useIdForHref = false; 
            // test id element is a url
            try
            {
                var xElement = xml.Element(_atomNamespace + "feed");
                if (xElement != null)
                {
                    var element = xElement.Element(_atomNamespace + "id");
                    if (element != null)
                    {
                        useIdForHref = element.Value.StartsWith("http://");
                    }
                }
            }
            catch { }


            return (from f in xml.Descendants(_atomNamespace + "entry")
                    let id = f.Element(_atomNamespace + "id")
                    where id != null
                    let link = f.Element(_atomNamespace + "link")
                    where link != null
                    let content = f.Element(_atomNamespace + "content")
                    where content != null
                    let title = f.Element(_atomNamespace + "title")
                    where title != null
                    let published = f.Element(_atomNamespace + "published")
                    where published != null
                    select new Item(useIdForHref ? id.Value : link.Attribute("href").Value,
                                    content.Value,
                                    HttpUtility.HtmlDecode(title.Value),
                                    published.Value)).ToList();
        }

        private void GetXml(Uri feedUri)
        {
            // should request feed url as xml and construct list of items
            var request = WebRequest.Create(feedUri);
            request.BeginGetResponse(ResponseComplete, request);
        }

        private void ResponseComplete(IAsyncResult result)
        {
            XDocument xDocument = null;
            var request = (HttpWebRequest)result.AsyncState;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(result);

                using (var dataStream = response.GetResponseStream())
                {
                    if (dataStream != null)
                    {
                        var reader = new StreamReader(dataStream);
                        // Read the content.
                        xDocument = XDocument.Parse(reader.ReadToEnd());
                    }
                }
            }
            catch (Exception)
            {
                xDocument = new XDocument();

                var e = new XElement("broken");

                xDocument.Add(e);
            }

            SetXml(xDocument);

            if (FeedLoaded != null)
            {
                FeedLoaded(this, EventArgs.Empty);
            }
        }

        public string Title { get; set; }

        public Uri FeedUri { get; set; }

        public List<Item> Items { get; set; }

        public Uri HtmlUri { get; set; }

        public string BaseUrl { get; set; }

        public string UpdateFrequency { get; set; }

        public string UpdatePeriod { get; set; }

        public string ETag { get; set; }

        public DateTime CacheExpiry { get; set; }

        public override bool Equals(object obj)
        {
            var o = obj as Feed;

            if (o == null)
            {
                return false;
            }

            if (ReferenceEquals(this, o))
            {
                return true;
            }

            return FeedUri.Equals(o.FeedUri);
        }

        public override int GetHashCode()
        {
            return FeedUri.GetHashCode();
        }

        public event EventHandler FeedLoaded;


    }
}