using System;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
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

        private double _duration;
        private void VerticalCompression_Fired(object sender, EventArgs e)
        {
            _duration = DateTime.Now.Ticks;

            Debug.WriteLine("VerticalCompression_Fired");
        }

        private void NoVerticalCompression_Fired(object sender, EventArgs e)
        {
            var d = DateTime.Now.Ticks - _duration;

            Debug.WriteLine("NoVerticalCompression_Fired");
            Debug.WriteLine(d);

            if (d > 10000000)
            {
                Debug.WriteLine("A second elapsed");
                ViewModel.Refresh();
            }
        }
    }
}