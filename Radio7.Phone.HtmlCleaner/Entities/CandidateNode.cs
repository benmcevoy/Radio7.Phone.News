using System;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Entities
{
    public class CandidateNode
    {
        public Guid Id { get; set; }

        public double Score { get; set; }

        public HtmlNode HtmlNode { get; set; }
    }
}
