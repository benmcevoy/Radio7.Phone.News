using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using GalaSoft.MvvmLight.Messaging;
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

        public CommentService(IMessenger messenger, StrategyResolver<ICommentExtractor> commentExtractorResolver)
        {
            _messenger = messenger;
            _commentExtractorResolver = commentExtractorResolver;
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
            var result = new StringBuilder(@"<html lang='en'>
<head><title></title>
<meta name='viewport' content='width=480' />
<style type='text/css'>
body, #body {{ background: black !important; margin: 10px; padding:0; width: 450px;}} 
h3 { margin: 0 0 0px 0; font-size: 32px; font-weight: 100; }
.comment {{ background: black !important; padding:0; font-size: 20px !important; margin: 0 0 25px 0; color: white !important;  }} 
font {{ background: black !important; padding:0; color: white !important; font-size: 18px !important; }}</style>
</head><body>
<div id='body'>");

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

            return result.ToString();
        }

        public event EventHandler<GetCommentsCompleteEventArgs> GetCommentsComplete;
    }
}
