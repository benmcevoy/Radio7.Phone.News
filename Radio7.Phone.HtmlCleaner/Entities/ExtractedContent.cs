using System;
using System.Collections.Generic;

namespace Radio7.Phone.HtmlCleaner.Entities
{
    public class ExtractedContent
    {
        public Uri Url { get; set; }

        public string Title  { get; set; }

        public string Text { get; set; }

        public string Summary { get; set; }

        public IEnumerable<string> Keywords { get; set; }

        public string Html { get; set; }

        public string Domain { get; set; }
    }
}
