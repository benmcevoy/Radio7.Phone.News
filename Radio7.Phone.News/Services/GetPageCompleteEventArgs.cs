using System;

namespace Radio7.Phone.News.Services
{
    public class GetPageCompleteEventArgs : EventArgs
    {
        public GetPageCompleteEventArgs(string content)
        {
            Content = content;
        }

        public string Content { get; set; }
    }
}