using System;
using System.Net;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Radio7.Phone.News.ViewModels;
using Radio7.Phone.News.Infrastructure;

namespace Radio7.Phone.News.Views
{
    public partial class ItemPage : PhoneApplicationPage
    {
        public ItemPage()
        {
            InitializeComponent();

            Browser.LoadCompleted += (sender, args) =>
            {
                Browser.OpacityMask = null;
                Browser.Opacity = 1;

                WithDispatcher(() => Browser.InvokeScript("eval",
                                                          "try{enablePrettyPrinting();}catch(e){}"));

            };

            Loaded += ItemPage_Loaded;
        }

        private void ItemPage_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= ItemPage_Loaded;

            (self.DataContext as ItemPageViewModel).NavigateToString += (o, args) => WithDispatcher(() =>
                {
                    Browser.NavigateToString(args.Content);
                    ProgressHelper.ClearMessage();
                });
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (NavigationContext.QueryString.ContainsKey("url"))
            {
                var url = new Uri(HttpUtility.UrlDecode(NavigationContext.QueryString["url"]));
                var vm = self.DataContext as ItemPageViewModel;

                // TODO: replace with messaging
                if (vm != null)
                {
                    vm.BeginLoad(url);
                    ProgressHelper.SetMessage("loading...");
                }
            }

            base.OnNavigatedTo(e);
        }

        public static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}