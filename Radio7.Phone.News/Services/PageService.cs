using System;
using System.IO;
using System.Net;
using System.Text;
using GalaSoft.MvvmLight.Messaging;
using Radio7.Phone.HtmlCleaner.Entities;
using Radio7.Phone.HtmlCleaner.Extractors.Content;
using Radio7.Phone.News.Data;
using Radio7.Phone.News.Messages;

namespace Radio7.Phone.News.Services
{
    public class PageService : IPageService
    {
        private readonly HtmlRepository _htmlRepository;
        private readonly IMessenger _messenger;
        private Uri _url;

        public PageService(HtmlRepository htmlRepository, IMessenger messenger)
        {
            _htmlRepository = htmlRepository;
            _messenger = messenger;
        }

        public void BeginGetPage(Uri uri)
        {
            _messenger.Send(ProgressMessage.EmptyMessage);

            _url = uri;

            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.AllowAutoRedirect = true;

            webRequest.CookieContainer = new CookieContainer();
            // seemed like a good idea, but most mobile sites are "modern"(ish), getting crap like ajax in the content and so on. Gratuitous Ajax.
            // webRequest.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3";
            webRequest.BeginGetResponse(OnLoad, webRequest);
        }

        public string CreatePage(string title, string html, Uri url)
        {
            var ce = new ContentExtractor();
            var clean = ce.Extract(html, url);

            return CreatePage(url.ToString(), title, clean.Html, clean.Domain);
        }

        private void OnLoad(IAsyncResult ar)
        {
            var request = ((HttpWebRequest)ar.AsyncState);

            try
            {
                using (var response = request.EndGetResponse(ar))
                using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    var html = reader.ReadToEnd();
                    var ce = new ContentExtractor();
                    var clean = ce.Extract(html, response.ResponseUri);
                    var page = CreatePage(_url.ToString(), clean.Title, clean.Html, clean.Domain);

                    RaiseGetPageComplete(clean, page);
                }
            }
            catch (WebException)
            {
                if (GetPageComplete == null) return;

                var page = CreatePage("#", "An error occurred", "<br/><br/><br/><br/>", "");

                GetPageComplete(this, new GetPageCompleteEventArgs(null, "", "", page));
            }
            finally
            {
                _messenger.Send(new ProgressMessage());
            }
        }

        private void RaiseGetPageComplete(ExtractedContent clean, string page)
        {
            if (GetPageComplete != null)
            {
                GetPageComplete(this, new GetPageCompleteEventArgs(clean.Url, clean.Title, clean.Text, page));
            }
        }

        private string CreatePage(string url, string title, string body, string domain)
        {
            var wrapper = _htmlRepository.GetWrapper();
            var script = _htmlRepository.GetScript();
            var style = _htmlRepository.GetStyle();

            return string.Format(wrapper, script, style, url, title, body, HttpUtility.HtmlEncode(title), domain);
        }

        // TODO: replace with messaging
        public event EventHandler<GetPageCompleteEventArgs> GetPageComplete;
    }
}
