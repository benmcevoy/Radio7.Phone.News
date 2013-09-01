using System;

namespace Rss.Manager.RelatedLinks
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RelatedLinkParserForAttribute : Attribute
    {
        public RelatedLinkParserForAttribute(string host)
        {
            Host = host;
        }

        public string Host { get; private set; }
    }
}
