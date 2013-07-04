using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Radio7.Phone.News.Infrastructure
{
    public static class ProgressHelper
    {
        public static void SetMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            var progress = new ProgressIndicator
            {
                IsVisible = true,
                IsIndeterminate = true,
                Value = 0,
                Text = message
            };

            WithDispatcher(() => SystemTray.SetProgressIndicator(GetVisual(), progress));
        }

        public static void ClearMessage()
        {
            WithDispatcher(() => SystemTray.SetProgressIndicator(GetVisual(), null));
        }

        private static PhoneApplicationPage GetVisual()
        {
            return (Application.Current.RootVisual as PhoneApplicationFrame).Content as PhoneApplicationPage;
        }

        private static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }
    }
}
