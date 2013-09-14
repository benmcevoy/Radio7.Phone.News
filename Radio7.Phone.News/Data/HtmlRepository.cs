using System;
using Radio7.Phone.News.Infrastructure;

namespace Radio7.Phone.News.Data
{
    public class HtmlRepository
    {
        private static string _script;
        public string GetScript()
        {
            if (string.IsNullOrEmpty(_script))
            {
                _script = ResourceHelper.LoadStringFromResource(new Uri("/Radio7.Phone.News;component/Resources/Scripts/prettify.js", UriKind.Relative));
            }

            return _script;
        }

        private static string _style;
        public string GetStyle()
        {
            if (string.IsNullOrEmpty(_style))
            {
                _style = ResourceHelper.LoadStringFromResource(new Uri("/Radio7.Phone.News;component/Resources/Css/base.css", UriKind.Relative));
            }

            return _style;
        }

        private static string _commentsStyle;
        public string GetCommentsStyle()
        {
            if (string.IsNullOrEmpty(_commentsStyle))
            {
                _commentsStyle = ResourceHelper.LoadStringFromResource(new Uri("/Radio7.Phone.News;component/Resources/Css/comments.css", UriKind.Relative));
            }

            return _commentsStyle;
        }

        private static string _wrapper;
        public string GetWrapper()
        {
            if (string.IsNullOrEmpty(_wrapper))
            {
                _wrapper = ResourceHelper.LoadStringFromResource(new Uri("/Radio7.Phone.News;component/Resources/Html/PageWrapper.html", UriKind.Relative));
            }

            return _wrapper;
        }

        private static string _commentsWrapper;
        public string GetCommentsWrapper()
        {
            if (string.IsNullOrEmpty(_commentsWrapper))
            {
                _commentsWrapper = ResourceHelper.LoadStringFromResource(new Uri("/Radio7.Phone.News;component/Resources/Html/CommentsWrapper.html", UriKind.Relative));
            }

            return _commentsWrapper;
        }
    }
}
