using Microsoft.Phone.Controls;
using System.Windows;

namespace Radio7.Phone.News
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= MainPage_Loaded;

            DataContext = App.ViewModel;

            // just doing things in a sane way causes ArgumentException to be thrown from the bowels
            // of silverlight dependancy object

            foreach (var topic in App.ViewModel.Topics)
            {
                var pivotItem = new PivotItem
                    {
                        Header = topic.Title
                    };

                MainPivot.Items.Add(pivotItem);
            }

            for (var i = 1; i <= App.ViewModel.Topics.Count; i++)
            {
                var newsItem = new NewsItemsControl(App.ViewModel.Topics[i - 1]);
                var pivotItem = MainPivot.Items[i] as PivotItem;

                if (pivotItem != null) pivotItem.Content = newsItem;
            }

            App.ViewModel.Load();
        }
    }
}