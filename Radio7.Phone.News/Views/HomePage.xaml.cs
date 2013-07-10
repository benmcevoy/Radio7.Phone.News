using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Radio7.Phone.News.ViewModels;

namespace Radio7.Phone.News.Views
{
    public partial class HomePage : PhoneApplicationPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private HomePageViewModel ViewModel
        {
            get { return Self.DataContext as HomePageViewModel; }
        }

        private void WithDispatcher(Action action)
        {
            Dispatcher.BeginInvoke(action);
        }
    }
}