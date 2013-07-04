using System;
using System.IO;
using System.Net;
using System.Text;
using Radio7.Phone.HtmlCleaner.Extractors.Content;
using Radio7.Phone.HtmlCleaner.Extractors.Title;
using Radio7.Phone.News.Data;

namespace Radio7.Phone.News.Services
{
    public class PageService : IPageService
    {
        private readonly HtmlRepository _htmlRepository;
        private Uri _url;

        public PageService(HtmlRepository htmlRepository)
        {
            _htmlRepository = htmlRepository;
        }

        public void BeginGetPage(Uri uri)
        {
            _url = uri;

            var webRequest = (HttpWebRequest)WebRequest.Create(uri);

            webRequest.CookieContainer = new CookieContainer();
            webRequest.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3";
            webRequest.BeginGetResponse(OnLoad, webRequest);

            // TODO: raise progress message
            //_progressService.SetMessage("loading...");
        }

        private void OnLoad(IAsyncResult ar)
        {
            var request = ((HttpWebRequest)ar.AsyncState);

            try
            {
                using (var response = request.EndGetResponse(ar))
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                {
                    var html = reader.ReadToEnd();
                    var ce = new ContentExtractor();
                    var clean = ce.Extract(html, response.ResponseUri);
                    var te = new TitleExtractor();
                    var title = te.Extract(html);
                    var page = CreatePage(_url.ToString(), title, clean);

                    if (GetPageComplete != null)
                    {
                        GetPageComplete(this, new GetPageCompleteEventArgs(page));
                    }
                }
            }
            catch (WebException)
            {
                if (GetPageComplete == null) return;

                var page = CreatePage("#", "An error occurred", "<br/><br/><br/><br/>");

                GetPageComplete(this, new GetPageCompleteEventArgs(page));
            }
            //finally
            //{
            //    // TODO: raise progress message
            //    //_progressService.ClearMessage();
            //}
        }

        private string CreatePage(string url, string title, string body)
        {
            var wrapper = _htmlRepository.GetWrapper();
            var script = _htmlRepository.GetScript();
            var style = _htmlRepository.GetStyle();

            return string.Format(wrapper, script, style, url, title, body, HttpUtility.HtmlEncode(title));
        }

        // TODO: replace with messaging
        public event EventHandler<GetPageCompleteEventArgs> GetPageComplete;
    }
}
