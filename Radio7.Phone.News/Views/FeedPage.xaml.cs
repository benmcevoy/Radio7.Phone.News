using System;
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
            base.OnNavigatedTo(e);

            string id;

            if (!NavigationContext.QueryString.TryGetValue("id", out id)) return;

            if (ViewModel != null) ViewModel.Load(Convert.ToInt32(id));
        }

        private FeedPageViewModel ViewModel
        {
            get { return Self.DataContext as FeedPageViewModel; }
        }

        private void WithDispatcher(Action action)
        {
            Dispatcher.BeginInvoke(action);
        }
    }
}