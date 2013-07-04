using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Radio7.Phone.News.Infrastructure
{
    public static class ProgressHelper
    {
        private static void WithDispatcher(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }

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

            SystemTray.SetProgressIndicator(GetVisual(), progress);
        }

        public static void ClearMessage()
        {
            SystemTray.SetProgressIndicator(GetVisual(), null);
        }

        private static PhoneApplicationFrame GetVisual()
        {
            return Application.Current.RootVisual as PhoneApplicationFrame;
        }
    }
}
