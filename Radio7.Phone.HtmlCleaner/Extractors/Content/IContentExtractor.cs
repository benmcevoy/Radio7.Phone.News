using Radio7.Phone.HtmlCleaner.Entities;
using System;

namespace Radio7.Phone.HtmlCleaner.Extractors.Content
{
    public interface IContentExtractor
    {
        ExtractedContent Extract(string html, Uri documentUrl);
    }
}
