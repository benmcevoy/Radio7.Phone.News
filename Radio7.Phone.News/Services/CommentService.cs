using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.News.Data;
using Radio7.Phone.News.Messages;
using Radio7.Phone.News.Models;
using Radio7.Phone.News.Services.Comments;
using Radio7.Portable.StrategyResolver;

namespace Radio7.Phone.News.Services
{
    public class CommentService : ICommentService
    {
        private readonly IMessenger _messenger;
        private readonly StrategyResolver<ICommentExtractor> _commentExtractorResolver;
        private readonly HtmlRepository _htmlRepository;

        public CommentService(IMessenger messenger, 
            StrategyResolver<ICommentExtractor> commentExtractorResolver, HtmlRepository htmlRepository)
        {
            _messenger = messenger;
            _commentExtractorResolver = commentExtractorResolver;
            _htmlRepository = htmlRepository;
        }

        public void BeginGetComments(Uri url)
        {
            var webClient = new WebClient();

            webClient.DownloadStringCompleted += (sender, args) =>
            {
                if (GetCommentsComplete == null) return;

                var extractor = _commentExtractorResolver.Resolve(url.Host, new DefaultCommentExtractor());
                var comments = extractor.Extract(args.Result);

                _messenger.Send(new ProgressMessage());

                var html = WrapComments(comments);

                GetCommentsComplete(this, new GetCommentsCompleteEventArgs(html));
            };

            _messenger.Send(new ProgressMessage(" "));

            webClient.DownloadStringAsync(url);
        }

        private string WrapComments(IEnumerable<Comment> comments)
        {
            var result = new StringBuilder();

            var commentArray = comments as Comment[] ?? comments.ToArray();

            if (commentArray.Any())
            {
                foreach (var comment in commentArray)
                {
                    result.Append(comment);
                }
            }
            else
            {
                result.Append("<div class='comment'>no comments found</div>");
            }

            result.Append("</div></body></html>");

            return string.Format(_htmlRepository.GetCommentsWrapper(), result, _htmlRepository.GetStyle(), _htmlRepository.GetCommentsStyle());
        }

        public event EventHandler<GetCommentsCompleteEventArgs> GetCommentsComplete;
    }
}
