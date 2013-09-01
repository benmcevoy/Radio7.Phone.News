using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Rss.Manager.RelatedLinks
{
    public class RelatedLinksParserResolver : IResolver<IRelatedLinksParser>
    {
        private static Dictionary<string, IRelatedLinksParser> _relatedLinksParsers;

        public IRelatedLinksParser Resolve(string host)
        {
            if (_relatedLinksParsers == null) Load();

            var lowerHost = host.ToLowerInvariant();

            if (_relatedLinksParsers != null && _relatedLinksParsers.ContainsKey(lowerHost))
            {
                return _relatedLinksParsers[lowerHost];
            }

            return new NoRelatedLinksParser();
        }

        private static void Load()
        {
            _relatedLinksParsers = new Dictionary<string, IRelatedLinksParser>(16);

            var parserType = typeof(IRelatedLinksParser);
            var assembly = Assembly.GetCallingAssembly();
            var types = assembly
                .GetTypes()
                .Where(t => parserType.IsAssignableFrom(t) && t.IsClass)
                .ToList();

            foreach (var type in types)
            {
                var parserFor = type.GetCustomAttributes(typeof(RelatedLinkParserForAttribute), false).FirstOrDefault();

                if (parserFor == null) continue;

                var relatedLinkParserForAttribute = parserFor as RelatedLinkParserForAttribute;

                if (relatedLinkParserForAttribute == null) continue;

                _relatedLinksParsers[relatedLinkParserForAttribute.Host] = (IRelatedLinksParser)Activator.CreateInstance(type);
            }
        }
    }
}
