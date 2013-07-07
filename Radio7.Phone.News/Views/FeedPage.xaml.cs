using System;
using System.Net;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Radio7.Phone.News.ViewModels;

namespace Radio7.Phone.News.Views
{
    public partial class FeedPage : PhoneApplicationPage
    {
        public FeedPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (NavigationContext.QueryString.ContainsKey("id"))
            {
                var id = Convert.ToInt32(HttpUtility.UrlDecode(NavigationContext.QueryString["id"]));
                var vm = Self.DataContext as FeedPageViewModel;

                // TODO: replace with messaging?
                if (vm != null) vm.Load(id);
            }

            base.OnNavigatedTo(e);
        }
    }
}