using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using Radio7.Phone.News.Models;

namespace Radio7.Phone.News.Converters
{
    public class ContentLevelToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var contentLevel = ((ContentLevel) value).ToString();

            if (contentLevel == (string) parameter)
            {
                return new SolidColorBrush(Colors.Yellow);
            }

            return new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
