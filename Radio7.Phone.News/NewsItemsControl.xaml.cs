using System.Windows.Controls;
using Radio7.Phone.News.ViewModels;

namespace Radio7.Phone.News
{
    public partial class NewsItemsControl : UserControl
    {
        private readonly Topic _topic;

        public NewsItemsControl(Topic topic)
        {
            _topic = topic;

            InitializeComponent();

            DataContext = _topic;
        }

        public NewsItemsControl()
        {
            InitializeComponent();   
        }
    }
}
